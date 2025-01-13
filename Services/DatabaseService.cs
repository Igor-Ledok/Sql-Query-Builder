using Microsoft.Data.SqlClient;
using WebApplication2.Models;

namespace WebApplication2.Services 
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<TableStructure>> GetDatabaseStructureAsync()
        {
            var tables = new List<TableStructure>();

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var queryTables = @"
                    SELECT TABLE_NAME 
                    FROM INFORMATION_SCHEMA.TABLES 
                    WHERE TABLE_TYPE = 'BASE TABLE'";

                using (var commandTables = new SqlCommand(queryTables, connection))
                {
                    using (var readerTables = await commandTables.ExecuteReaderAsync())
                    {
                        while (await readerTables.ReadAsync())
                        {
                            tables.Add(new TableStructure
                            {
                                TableName = readerTables["TABLE_NAME"].ToString(),
                                Columns = new List<ColumnStructure>(),
                                ForeignKeys = new List<string>()
                            });
                        }
                    }
                }

                foreach (var table in tables)
                {
                    var queryColumns = @"
                        SELECT COLUMN_NAME, DATA_TYPE 
                        FROM INFORMATION_SCHEMA.COLUMNS 
                        WHERE TABLE_NAME = @TableName";

                    using (var commandColumns = new SqlCommand(queryColumns, connection))
                    {
                        commandColumns.Parameters.AddWithValue("@TableName", table.TableName);

                        using (var readerColumns = await commandColumns.ExecuteReaderAsync())
                        {
                            while (await readerColumns.ReadAsync())
                            {
                                table.Columns.Add(new ColumnStructure
                                {
                                    ColumnName = readerColumns["COLUMN_NAME"].ToString(),
                                    DataType = readerColumns["DATA_TYPE"].ToString()
                                });
                            }
                        }
                    }

                    var queryForeignKeys = @"
                        SELECT COLUMN_NAME 
                        FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
                        WHERE TABLE_NAME = @TableName";

                    using (var commandFK = new SqlCommand(queryForeignKeys, connection))
                    {
                        commandFK.Parameters.AddWithValue("@TableName", table.TableName);

                        using (var readerFK = await commandFK.ExecuteReaderAsync())
                        {
                            while (await readerFK.ReadAsync())
                            {
                                table.ForeignKeys.Add(readerFK["COLUMN_NAME"].ToString());
                            }
                        }
                    }
                }
            }

            return tables;
        }

        public async Task<List<Dictionary<string, object>>> ExecuteQueryAsync(string query)
        {
            var result = new List<Dictionary<string, object>>();

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var row = new Dictionary<string, object>();
                            for (var i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }
                            result.Add(row);
                        }
                    }
                }
            }

            return result;
        }
    }
}
