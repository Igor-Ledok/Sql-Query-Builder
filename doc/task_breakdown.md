# Task Breakdown for SQL Query Builder

## 1. Tables
- Provide users with the ability to select tables from the database.
- Enable users to select multiple tables simultaneously.
- Allow users to remove selected tables from the query.
- Upon table removal, all related elements (sorting, filters, joins) must be removed.

---

## 2. Joins (JOIN)
- Automatically detect joins between tables based on foreign keys.
- Provide the ability to manually add, modify, and delete joins.
- Allow users to select the type of join (`INNER JOIN`, `LEFT JOIN`, etc.).
- Joins must be removed automatically if one of the tables is deleted.

--- 

## 3. Columns
- Display a list of available columns for the selected tables.
- Enable users to select columns to include in the query.
- Remove columns from the query when their associated table is deleted.

---

## 4. Filters (WHERE)
- Allow users to add data filtering conditions.
- Support logical operators (`AND`, `OR`) and grouping conditions using parentheses.
- Display a list of active filters with options for editing and deleting them.
- Filters related to a deleted table or column must be automatically removed.

---

## 5. Sorting and Grouping
- Enable column selection for sorting and specify the direction (ASC/DESC).
- Support grouping (`GROUP BY`) with multiple columns and aggregate functions (SUM, AVG, COUNT).
- Grouping is available only for selected columns, while others must use aggregate functions.
- Remove related sorting and grouping parameters automatically when columns are deleted from the tables.

---

## 6. SQL Query Generation and Execution
- Automatically update the SQL query based on changes to user-defined parameters.
- Implement query execution and display results in a tabular format.
- Allow users to execute the query and view the results in a table.

---

## 7. Error Handling
- Implement error handling for SQL query execution (e.g., syntax errors or unavailable tables).
- Display user-friendly error messages.
- Notify users if the query cannot be executed due to configuration errors.