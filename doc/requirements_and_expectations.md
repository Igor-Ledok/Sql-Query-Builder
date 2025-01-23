# Requirements for SQL Query Builder

## 1. Functional Requirements

- Provide an interface for selecting tables from the database.
- Enable creating and configuring relationships (`JOIN`) between selected tables.
- Support column selection, adding filters (`WHERE`), setting sorting (`ORDER BY`), and grouping (`GROUP BY`) parameters.
- Automatically generate SQL queries based on user actions.
- Execute SQL queries and display the results.
- Automatically detect relationships between tables using foreign keys.
- Display error messages for incorrect query configurations.

---

## 2. Non-Functional Requirements

- The program must support relational databases (e.g., MySQL, PostgreSQL, MSSQL).
- The interface should be intuitive, minimizing the number of user actions required.

---

## 3. Constraints

- The program is designed exclusively for working with relational databases.

---

## 4. Special Conditions 
 
- For complex queries, the user can switch to manual SQL editing via a built-in text editor.
