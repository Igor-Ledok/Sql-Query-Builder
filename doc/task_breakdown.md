# SQL Query Builder Task Breakdown

## Task 1: UI structure and SQL input field (2 days)
- Create the initial UI structure with sections: Tables, Joins, SQL Query, Columns, Filters, Sorting, Query Result.
- Add a static SQL query input field where users can manually enter queries.

---

## Task 2: Selecting a single table (1 day)
- Display a list of available tables.
- Allow users to select one table.
- Once selected, update the SQL query field to reflect the chosen table as the query source.

---

## Task 3: Selecting columns (1 day)
- Display available columns from the selected table.
- Allow users to select one or more columns for the query.
- When a column is selected, update the SQL query field to include only those columns.

---

## Task 4: Selecting multiple tables and handling joins (2 days)
- Allow users to add additional tables after selecting the first one.
- Ensure that only tables with direct relationships to already selected tables can be added.
- When a new table is added, automatically detect and display possible joins.
- Update the SQL query field to reflect table relationships dynamically.
- If many related tables exist, provide pagination or a search/filtering mechanism.

---

## Task 5: Filtering data (WHERE) (1 day)
- Allow users to define filters using available columns, operators, and values.
- Dynamically update the SQL query field to include the defined `WHERE` conditions.

---

## Task 6: Sorting (ORDER BY) (1 day)
- Allow users to specify sorting conditions by selecting columns and sorting direction (ASC/DESC).
- Display all applied sorting rules.
- Update the SQL query field dynamically to reflect the `ORDER BY` clause.

---

## Task 7: Grouping (GROUP BY, HAVING) (1 day)
- Allow users to group query results using `GROUP BY`.
- Allow users to define conditions on grouped results using `HAVING`.
- Display all applied groupings and conditions.
- Dynamically update the SQL query field with `GROUP BY` and `HAVING`.