public class SQLQueryBuilder
{
    private string _query = "";
    private List<string> _selectedTables = new List<string>();
    private List<string> _selectedColumns = new List<string>();
    private List<string> _joins = new List<string>();
    private List<string> _filters = new List<string>();
    private List<string> _sorting = new List<string>();
    private List<string> _grouping = new List<string>();
    private List<string> _having = new List<string>();

    public void InitializeUI()
    {
        // Setup UI with sections: Tables, Joins, SQL Query, Columns, Filters, Sorting, Query Result
        SetupUILayout();
    }

    public void SelectTable(string tableName)
    {
        if (!_selectedTables.Contains(tableName))
        {
            _selectedTables.Add(tableName);
            UpdateSQLQuery();
        }
    }

    public void SelectColumns(List<string> columns)
    {
        _selectedColumns = columns;
        UpdateSQLQuery();
    }

    public void SelectAdditionalTable(string tableName)
    {
        if (!_selectedTables.Contains(tableName) && IsTableRelated(tableName))
        {
            _selectedTables.Add(tableName);
            _joins.Add(GetAutoJoinCondition(tableName));
            UpdateSQLQuery();
        }
    }

    private bool IsTableRelated(string tableName)
    {
        // Check if the table has a predefined relationship with already selected tables
        return GetAvailableRelatedTables().Contains(tableName);
    }

    private string GetAutoJoinCondition(string tableName)
    {
        // Retrieve automatically determined join condition
        return "JOIN " + tableName + " ON " + GetPredefinedJoinCondition(tableName);
    }

    public void RemoveTable(string tableName)
    {
        if (_selectedTables.Contains(tableName))
        {
            _selectedTables.Remove(tableName);
            _joins.RemoveAll(j => j.Contains(tableName)); // Remove related JOINs
            UpdateSQLQuery();
        }
    }

    public void AddFilter(string column, string operation, string value)
    {
        _filters.Add($"{column} {operation} '{value}'");
        UpdateSQLQuery();
    }

    public void RemoveFilter(string column)
    {
        _filters.RemoveAll(f => f.StartsWith(column + " "));
        UpdateSQLQuery();
    }

    public void AddSorting(string column, string direction)
    {
        _sorting.Add($"{column} {direction}");
        UpdateSQLQuery();
    }

    public void RemoveSorting(string column)
    {
        _sorting.RemoveAll(s => s.StartsWith(column + " "));
        UpdateSQLQuery();
    }

    public void AddGrouping(string column)
    {
        _grouping.Add(column);
        UpdateSQLQuery();
    }

    public void RemoveGrouping(string column)
    {
        _grouping.Remove(column);
        _having.RemoveAll(h => h.Contains(column)); // Remove related HAVING conditions
        UpdateSQLQuery();
    }

    public void AddHavingCondition(string condition)
    {
        if (_grouping.Count > 0)
        {
            _having.Add(condition);
            UpdateSQLQuery();
        }
    }

    public void RemoveHavingCondition(string condition)
    {
        _having.Remove(condition);
        UpdateSQLQuery();
    }

    public List<string> DisplayJoins()
    {
        return _joins;
    }

    private void UpdateSQLQuery()
    {
        _query = "SELECT " + (_selectedColumns.Count > 0 ? string.Join(", ", _selectedColumns) : "*") +
                 " FROM " + string.Join(", ", _selectedTables);

        if (_joins.Count > 0)
            _query += " " + string.Join(" ", _joins);

        if (_filters.Count > 0)
            _query += " WHERE " + string.Join(" AND ", _filters);

        if (_grouping.Count > 0)
            _query += " GROUP BY " + string.Join(", ", _grouping);

        if (_having.Count > 0)
            _query += " HAVING " + string.Join(" AND ", _having);

        if (_sorting.Count > 0)
            _query += " ORDER BY " + string.Join(", ", _sorting);
    }

    public string GetSQLQuery()
    {
        return _query;
    }

    private void SetupUILayout()
    {
        // Create UI sections and link them to the query builder
    }
}
