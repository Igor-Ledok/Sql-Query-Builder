using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class TableStructure
    {
        public string TableName { get; set; }
        public List<ColumnStructure> Columns { get; set; }
        public List<string> ForeignKeys { get; set; } // Связи
    }

    public class ColumnStructure
    {
        public string ColumnName { get; set; }
        public string DataType { get; set; }
    }
}
