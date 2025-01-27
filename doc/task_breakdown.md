# SQL Query Builder Task Breakdown

## 1. Table Management
- Add a list of tables from the database.
- Add functionality for users to select one or more tables for the query.
- Add functionality for users to remove tables from the selection.
- Implement removal of related joins, filters, sorting and grouping options.
- Implement dynamic updating of the lists of available and columns.
---

## 2. Connection Management
- Implement automatic detection of possible joins between tables based on foreign keys.
- Add functionality for users to manually configure joins by specifying conditions and types (`INNER JOIN`, `LEFT JOIN`, etc.).
- Add functionality for users to modify or delete existing joins.
- Implement automatic removal of joins when a related table is removed.

---

## 3. Column Management
- Implement display of a list of available columns for each selected table.
- Add functionality for users to select columns to include in the query.
- Add functionality for users to remove columns from the query when the table associated with them is deleted.
- Implement dynamic updating of the column list as tables are added or removed.

---

## 4. Filter Management
- Add functionality for users to add filters (`WHERE` conditions) by specifying columns, operators (`=`, `>`, `<`, etc.) and values.
- Add functionality for users to use logical operators (`AND`, `OR`) and group conditions with parentheses.
- Add functionality for users to edit or delete existing filters.
- Implement automatic removal of filters associated with deleted tables or columns.
- Implement validation of user input for compatibility with column data types.

---

## 5. Sorting and Grouping
- Add functionality to select columns to sort by and specify direction (ASC/DESC).
- Add functionality to customize grouping (`GROUP BY`) for selected columns.
- Add functionality to apply aggregate functions (SUM, AVG, COUNT, etc.) to ungrouped columns.
- Implement automatic removal of sorting and grouping parameters if the columns associated with them are removed.

---

## 6. Creating and executing SQL query
- Implement automatic generation of SQL query based on user input.
- Implement inclusion of selected tables, joins, columns, filters, sorting and grouping in the query.
- Implement display of generated SQL queries in read-only format for user review.

---

## 7. Error handling
- Implement validation of all user input to ensure the correctness of the query.
- Implement display of errors for missing required elements such as tables or columns.
- Implement error reporting for invalid or conflicting parameters in filters, joins or sorts.