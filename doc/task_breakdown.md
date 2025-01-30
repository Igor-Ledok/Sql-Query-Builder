# SQL Query Builder Task Breakdown

## Task 1: Basic structure and first working query (2 days)
- Implement a basic UI layout with components: Tables, Columns, Filters, Sorting, Joins
- Implement functionality to display a list of available database tables
- Implement selection of a single table for query execution
- Implement execution of SELECT * FROM table for the selected table
- Display the query result in a table format
- Implement basic error handling for missing table selection

Expected result:
- The user sees the UI, can select a table, and retrieve all its data using SELECT * FROM table
- If no table is selected, an error message is shown

---

## Task 2: Selecting columns (1 day)
- Implement display of available columns for selected tables
- Add functionality to select specific columns for query execution
- Implement execution of queries with selected columns (SELECT column1, column2 FROM table)
- Implement error handling for missing column selection

Expected result:
- The user can select which columns to include in the query and retrieve data only for them
- If no column is selected, an error message is shown

---

## Task 3: Multiple tables and handling joins (1 day)
- Add functionality to select multiple tables
- Implement automatic detection of possible joins between selected tables
- Implement execution of queries with multiple tables
- Implement error handling for missing joins or incorrectly configured relationships

Expected result:
- The user can select multiple tables, the system automatically detects relationships, and the query includes the correct join conditions
- If a join is missing or incorrectly configured, an error message is shown

---

## Task 4: Filtering data (WHERE) (2 days)
- Implement functionality to add filters (WHERE conditions) with columns, operators, and values
- Implement execution of queries with filtering
- Implement UI for adding, editing, and removing filters
- Implement error handling for invalid or missing filters

Expected result:
- The user can add filter conditions, and the query returns filtered data
- If a filter is invalid or missing, an error message is shown

---

## Task 5: Sorting and grouping (1 day)
- Add functionality to sort results (ORDER BY)
- Add functionality to group data (GROUP BY)
- Implement execution of queries with sorting and grouping
- Implement error handling for invalid sorting or grouping configurations

Expected result:
- The user can apply sorting and grouping to the data
- If sorting or grouping is invalid, an error message is shown
