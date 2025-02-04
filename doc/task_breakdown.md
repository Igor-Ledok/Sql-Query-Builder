# SQL Query Builder Task Breakdown 

## Task 1: UI and initial structure (2 days)
- Create a UI layout with sections: Tables, Joins, SQL Query, Columns, Filters, Sorting, Query Result.
- Provide an interface where users can configure query parameters step by step.
- Display the SQL query dynamically as the user selects tables, columns, filters, and other query elements.
- Ensure that each selection updates the displayed SQL query but does not execute it yet.

---

## Task 2: Selecting a single table (1 day)
- Display a list of available tables.
- Allow users to select one table.
- Once selected, update the SQL query to reflect the chosen table as the query source.
- The SQL query display updates dynamically but remains unexecuted.

---

## Task 3: Selecting columns (1 day)
- Display available columns from the selected table.
- Allow users to select one or more columns for the query.
- When a column is selected, update the SQL query to include only those columns.
- If too many columns exist, provide search or filtering options.

---

## Task 4: Selecting multiple tables and handling joins (2 days)
- Allow users to add additional tables after selecting the first one.
- Ensure that only tables with direct relationships to already selected tables can be added.
- When a new table is added, automatically detect and display possible joins.
- Update the SQL query to reflect table relationships dynamically.
- If many related tables exist, provide pagination or a search/filtering mechanism.

---

## Task 5: Filtering data (WHERE) (1 day)
- Allow users to define filters using available columns, operators, and values.
- Display all applied filters in a structured format.
- Dynamically update the SQL query to include the defined `WHERE` conditions.

---

## Task 6: Sorting (ORDER BY) (1 day)
- Allow users to specify sorting conditions by selecting columns and sorting direction (ASC/DESC).
- Display all applied sorting rules.
- Update the SQL query dynamically to reflect the `ORDER BY` clause.

---

## Task 7: Grouping (GROUP BY, HAVING) (1 day)
- Allow users to group query results using `GROUP BY`.
- Allow users to define conditions on grouped results using `HAVING`.
- Display all applied groupings and conditions.
- Dynamically update the SQL query with `GROUP BY` and `HAVING`.