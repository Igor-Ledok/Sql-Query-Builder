
# Task Breakdown for SQL Query Builder Development

## 1. Main Development Stages

### 1.1 Working with Tables
- Tasks:
  - Implement functionality to display a list of tables from the database.
  - Add the ability to select multiple tables simultaneously.
  - Configure the removal of tables from the current selection set.
- Technical Details:
  - Use an API to fetch the list of tables from the database.
  - Ensure that removing a table correctly updates associated data (sorting, filters, relationships).

### 1.2 Configuring Table Relationships
- Tasks:
  - Implement automatic detection of relationships between tables (based on foreign keys).
  - Add the ability to create, modify, and delete relationships manually.
- Technical Details:
  - Verify the correct removal of a relationship if one of the tables is deselected.
  - Add error messages for incorrectly configured relationships.

### 1.3 Selecting Columns
- Tasks:
  - Display a list of available columns for the selected tables.
  - Implement the ability to select columns to include in the SQL query.
  - Ensure that removing a table also removes its columns from the query.
- Technical Details:
  - Update the interface in real-time when tables or columns are added/removed.

### 1.4 Configuring Filters (WHERE)
- Tasks:
  - Add the ability to specify filtering conditions.
  - Implement support for operators such as `=`, `>`, `<`, `LIKE`, etc.
  - Ensure that filters are correctly removed when columns or tables are deleted.
- Technical Details:
  - Validate user-provided values.
  - Display a list of active filters with options to edit or delete them.

### 1.5 Sorting and Grouping
- Tasks:
  - Configure column selection for sorting and specify the direction (ASC/DESC).
  - Implement support for grouping (`GROUP BY`) and aggregate functions (SUM, AVG, COUNT, etc.).
  - Ensure parameters are correctly updated when columns are removed.
- Technical Details:
  - Grouping should only be available for selected columns, while others must use aggregate functions.

---

## 2. SQL Query Generation

### 2.1 Query Generation Logic
- Tasks:
  - Automatically generate the SQL query when parameters are modified.
  - Ensure the query is updated correctly when elements (tables, columns, filters, etc.) are added/removed.
- Technical Details:
  - Add error handling for invalid queries.
  - Use parameterized queries to prevent SQL injection.

### 2.2 Executing Queries
- Tasks:
  - Implement the ability to send the generated query to the server for execution.
  - Display query results in a tabular format.
- Technical Details:
  - Provide support for paginated result display. 
  - Implement data export to CSV or Excel. 

---

## 3. Error Handling and Exception Management

- Tasks:
  - Implement error handling for query execution (e.g., syntax errors or unavailable tables).
  - Display user-friendly error messages.
- Technical Details:
  - Log errors on the server for further analysis.