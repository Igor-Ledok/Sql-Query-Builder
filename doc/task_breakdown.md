# SQL Query Builder Task Breakdown

## Task 1: UI for SQL Query and Query Result (1 day)
- Create a UI layout with sections for SQL Query and Query Result.
- Add a SQL query editor where users can manually enter and modify queries.
- Display the resulting SQL query in the Query Result section.

---

## Task 2: Selecting a Single Table (1 day)
- Create a UI section for table selection.
- Display a list of available tables retrieved from the database.
- Allow users to select one table from the list.
- After selection, the SQL query updates to include FROM <selected_table>.
- If many tables exist, provide search and pagination for better navigation.

---

## Task 3: Selecting Columns (1 day)
- Create a UI section for column selection.
- Display available columns for the selected table.
- Allow users to select multiple columns to include in the query.
- SQL query updates to SELECT <selected_columns> FROM <selected_table>.
- If a table is deselected, its columns are automatically removed from the query.
- If there are many columns, provide search and filtering options within the column selection panel.

---

## Task 4: Selecting Multiple Tables and Handling Joins (2 days)
- Create a user interface section for selecting additional tables and showing joins.
- Allow users to select additional tables that have direct relationships to the already selected table.
- The system only displays tables that are related based on foreign keys; users cannot add arbitrary tables.
- When a table is added, the system automatically detects and displays available joins, but users cannot modify join conditions.
- Users can only add tables that have pre-existing relationships; manually configuring joins is not allowed.
- SQL query updates to JOIN <table> ON <join_condition> for selected tables.
- If many related tables exist, allow pagination or filtering in the table selection panel.

---

## Task 5: Filtering Data (WHERE) (1 day)
- Create a UI section for filtering data.
- Allow users to define filters using available columns, operators (=, >, <, etc.), and values.
- Display applied filters directly in the UI under the WHERE section.
- SQL query updates to WHERE <column> <operator> <value>.
- If a table or column used in a filter is removed, the associated filter is also removed automatically.

---

## Task 6: Sorting (ORDER BY) (1 day)
- Create a UI section for sorting.
- Allow users to specify sorting conditions by selecting columns and sorting direction (ASC/DESC).
- Display applied sorting rules in the sorting section of the UI.
- SQL query updates to ORDER BY <column> <direction>.
- Users can modify or remove sorting conditions before applying changes.

---

## Task 7: Grouping (GROUP BY, HAVING) (1 day)
- Create a UI section for grouping.
- Allow users to group results by selecting one or more columns for GROUP BY.
- Ensure that only columns included in SELECT can be grouped.
- SQL query updates to GROUP BY <columns>.
- Allow users to define aggregate conditions using HAVING (e.g., HAVING COUNT(*) > 10).
- If grouping is removed, associated HAVING conditions are also removed.
- Users can modify or remove grouping conditions before applying changes.
