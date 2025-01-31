# SQL Query Builder Task Breakdown

## Task 1: UI and SQL query field (2 days)
- Create a UI layout with sections for Tables, Joins, SQL query, Columns, Filters, Sorting, SQL query result
- Display the SQL query generated from user selections
- Allow users to manually input and modify the SQL query

Expected result:
- The UI contains sections for Tables, Joins, SQL query, Columns, Filters, Sorting, SQL query result
- The user can manually enter an SQL query
- The system executes the SQL query when triggered by the user
- The system displays the query result in the SQL query result section

---

## Task 2: Single table (1 day)
- Display a list of tables
- Allow selection of a single table
- Add the selected table to the SQL query

Expected result:
- The system displays a list of available database tables
- The user can select one table
- The selected table is added to the SQL query

---

## Task 3: Columns (1 day)
- Display columns from selected tables
- The user can select columns to execute the query
- Update the SQL query with the selected columns

Expected result:
- The system displays available columns for selected tables
- The user can select columns
- The SQL query updates with the selected columns

---

## Task 4: Multiple tables with joins (2 days)
- Display joins of the selected tables
- Allow selection of multiple tables
- Ensure that only tables with relationships to the already selected ones can be added
- Automatically add detected joins when multiple tables are selected

Expected result:
- The user sees the joins of the selected tables.
- The user can select multiple tables
- Only tables with relationships to already selected tables can be added
- The system automatically updates the SQL query with JOIN conditions when multiple tables are selected

---

## Task 5: Filtering data (WHERE) (1 day)
- Allow users to add, edit, and delete filters using columns, operators, and values
- Update the SQL query with filters

Expected result:
- User can add, edit and delete filters using columns, operators and values
- User is shown existing filters
- System updates SQL query with `WHERE` conditions

---

## Task 6: Sorting (ORDER BY) (1 day)
- Allow users to sort query results by selecting columns and sort direction (ASC/DESC)
- Update the SQL query with sorting

Expected result:
- The user can add, edit and delete sorts using columns, operators and values
- User is shown existing sorts
- The system updates the SQL query with `ORDER BY`

---

## Task 7: Grouping (GROUP BY, HAVING) (1 day)
- Allow users to group data using `GROUP BY`
- Allow users to apply conditions on grouped data using `HAVING`
- Update the SQL query with grouping

Expected result:
- The user is shown the existing groupings
- The user can select columns for grouping
- The user can apply conditions on grouped data using `HAVING`
- The system updates the SQL query with `HAVING` conditions
- The system updates the SQL query with `GROUP BY`