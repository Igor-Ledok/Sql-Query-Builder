# Requirements and Expectations for SQL Query Builder

## 1. Functional Requirements

### 1.1 Core Functionality
- The program must provide an interface for selecting tables from the database.
- Ability to create and configure relationships (JOIN) between selected tables.
- Selection of columns to include in the SQL query.
- Adding filters (`WHERE`) with specified conditions.
- Configuration of sorting (`ORDER BY`) and grouping (`GROUP BY`) parameters.
- Automatic generation of an SQL query based on user actions.
- Execution of the generated SQL query and display of results in a table. 

### 1.2 Additional Functionality
- Automatic detection of relationships between tables if specified via foreign keys.
- Support for both simple and complex filters (e.g., `AND`, `OR`).
- Error messages in case of incorrect query configurations.

## 2. Non-Functional Requirements

- The interface must be intuitive, requiring minimal actions to complete a task.
- The program must support popular databases: MySQL, PostgreSQL, MSSQL.

---

## 3. Constraints

- The program is designed to work only with relational databases.
- Users must have basic SQL knowledge to understand the query results.

---

## 4. Expectations

- The program should simplify the process of building SQL queries for users with minimal programming knowledge.
- The program should be usable by both developers and technical specialists.
- There must be documentation with examples of how to use all program functions.

---

## 5. Special Conditions

- For complex queries, the user must be able to switch to manual SQL editing via a built-in text editor.
