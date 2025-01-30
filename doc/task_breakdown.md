# SQL Query Builder Task Breakdown

## Stage 1: Basic structure and first working query (1 day)
- Implement a basic UI layout with components: Tables, Columns, Filters, Sorting, Joins
- Implement functionality to display a list of available database tables
- Implement selection of a single table for query execution
- Implement execution of SELECT * FROM table for the selected table
- Display the query result in a table format

Expected result:
- The user sees the UI, can select a table, and retrieve all its data using SELECT * FROM table

---

## Stage 2: Multiple tables and handling joins (1 day)
- Add functionality to select multiple tables
- Implement automatic detection of possible joins between selected tables
- Implement execution of queries with multiple tables

Expected result:
- The user can select multiple tables, the system automatically detects relationships, and the query includes the correct join conditions

---

## Stage 3: Columns (1 day)
- Implement display of available columns for selected tables
- Add functionality to select specific columns for query execution
- Implement execution of queries with selected columns

Expected result:
- The user can select which columns to include in the query and retrieve data only for them

---

## Stage 4: Filtering data (WHERE) (2 days)
- Implement functionality to add filters (WHERE conditions) with columns, operators, and values
- Implement execution of queries with filtering 
- Implement UI for adding, editing, and removing filters

Expected result:
- The user can add filter conditions, and the query returns filtered data

---

## Stage 5: Sorting and grouping (1 day)
- Add functionality to sort results (ORDER BY)
- Add functionality to group data (GROUP BY)
- Implement execution of queries with sorting and grouping

Expected result:
- The user can apply sorting and grouping to the data

---

## Stage 6: Generating and editing SQL queries (1 day)
- Implement display of the generated SQL query
- Implement the ability to edit the SQL query manually
- Implement execution of manually edited queries

Expected result:
- The system displays the generated SQL query, and the user can edit it before execution

---

## Stage 7: Error handling (2 days)
- Implement validation of user input
- Implement error messages for missing required elements (for example, attempting to execute a query without selecting a table)
- Implement automatic removal of invalid filters, sorting, and grouping conditions

Expected result:
- The user receives clear error messages, and the system prevents invalid query configurations