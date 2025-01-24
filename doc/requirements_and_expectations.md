# Requirements and Expectations for SQL Query Builder

## 1. Functional Requirements

- Provide an interface for selecting tables and their columns from the database.
- Enable the creation and configuration of joins (`JOIN`) between selected tables:
  - Support for join types: `INNER JOIN`, `LEFT JOIN`, `RIGHT JOIN`, `FULL JOIN`.
  - Automatic detection of joins based on foreign keys.
- Support column selection, adding filters (`WHERE`), setting sorting (`ORDER BY`), and grouping (`GROUP BY`).
  - Support composite filtering conditions using logical operators (`AND`, `OR`) and parentheses.
  - Provide users with a preview of active filters with options for editing and deleting them.
- Automatically generate SQL queries based on the user’s selection (e.g., tables, columns, conditions, and sorting).
- Execute SQL queries and display the results in a tabular format.
- Allow switching to manual SQL editing via a built-in text editor for complex queries.
- Display informative error messages explaining the reasons (e.g., syntax errors or absence of selected data).
- Allow users to save and load generated SQL queries for future use.

--- 

## 2. Constraints

- The program is designed exclusively for working with relational databases.

---

## 3. Assumptions

- The program must support relational databases (e.g., MySQL, PostgreSQL, MSSQL).
- Users of the program possess basic SQL knowledge to understand query results.
- The program assumes that users have a basic understanding of relational database concepts, such as tables, joins (`JOIN`), and filters (`WHERE`).
- For complex queries, the user can switch to manual SQL editing using the built-in text editor.
