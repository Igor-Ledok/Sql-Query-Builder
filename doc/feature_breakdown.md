# SQL Query Builder: Task Breakdown

This is a breakdown of tasks for building the **SQL Query Builder** application.

---

## 1. Interface for Building SQL Queries
- **Table Selection:**
  - A dropdown list to display available tables from the database.
  - The ability to select multiple tables at once.
  - A "Add Table" button to add selected tables to the current query.
  - A "Clear Selection" button to reset selected tables.

- **Column Selection:**
  - Checkbox lists for selecting columns from the chosen tables.
  - Display a message "Please select tables first" if no tables are selected.

- **Adding Filters (WHERE):**
  - Fields to specify conditions:
    - A dropdown list for columns.
    - A dropdown list for operators (`=`, `>`, `<`).
    - A field to input a value.
  - An "Add Filter" button to add new conditions.
  - A "Clear Filters" button to remove all set conditions.

- **Sorting (ORDER BY):**
  - A dropdown list for selecting a column to sort by.
  - The ability to specify the sorting order (ASC or DESC).
  - An "Add Sorting" button to add sorting parameters.
  - A "Clear Sorting" button to reset sorting parameters.

---

## 2. Generating and Displaying SQL Queries
- **Generation Logic:**
  - Create a function for automatically constructing the SQL query:
    - Generate `SELECT` with selected columns.
    - Generate `FROM` with selected tables.
    - Generate `WHERE` with provided filters.
    - Generate `ORDER BY` with specified sorting parameters.
  - Handle table joins (JOIN) based on foreign keys.

- **Viewing the Query:**
  - Display the generated SQL query in a text area for review.
  - Dynamically update the query text when parameters change.

---

## 3. Executing the Query and Displaying Results
- **"Execute Query" Button:**
  - Implement a button to send the generated SQL query to the server.

- **Data Retrieval:**
  - Write a method in the service to execute queries.
  - Return data from the database in JSON format.

- **Displaying Results:**
  - Display the query results in an HTML table using `<table>`, `<th>`, `<tr>`, `<td>` tags.
  - Add a "No data" message if the query result is empty.

---

## 4. Working with Table Joins (JOIN)
- **Automatic Relationship Detection:**
  - Use foreign keys to automatically create relationships between tables.
  - Implement a view for automatic relationships.

- **Selecting Join Type:**
  - Add the ability to select the join type (`INNER JOIN`, `LEFT JOIN`, `RIGHT JOIN`, `FULL JOIN`).

- **Generating JOIN Queries:**
  - Update the query generation logic to handle joins between tables.
