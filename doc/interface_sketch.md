# SQL Query Builder Interface Sketch

## Description of the Interface and Functional Flow

---

### 1. Table Selection and Relationship Creation

- Description:
  The user selects tables for work and configures relationships between them (if necessary).

- Functional Flow:
  - The user selects one or more tables from a list with support for multiple selections.
  - Selected tables are visualized graphically, showing their relationships (e.g., with arrows).
  - If foreign keys exist, relationships are added automatically. Users can manually create, modify, or delete these relationships.
  - Parameters for each relationship include:
    - Join type (`INNER JOIN`, `LEFT JOIN`, etc.).
    - Join condition (e.g., `Orders.CustomerID = Customers.CustomerID`).

---

### 2. Column Selection

- Description:
  The user selects columns from the chosen tables to include in the query.

- Functional Flow: 
  - Columns are displayed in a list, fully qualified with table names (e.g., `Orders.OrderDate`).
  - The user selects columns via checkboxes, which are then automatically included in the query.

---

### 3. Adding Filters (WHERE)

- Description:
  The user configures filters to narrow down the data in the query.

- Functional Flow:
  - For each filter, the user selects a column, an operator (`=`, `>`, `<`, etc.), and specifies a value.
  - All filters are listed with options to edit or remove them.

---

### 4. Sorting Configuration (ORDER BY)

- Description:
  The user specifies sorting preferences for the query.

- Functional Flow:
  - A sorting column and direction (ASC/DESC) are selected.
  - All sorting parameters are listed, and users can modify or remove them.

---

### 5. SQL Query Generation and Execution

- Description:
  The system generates an SQL query automatically based on user input. The user can review and execute it.

- Functional Flow:
  - The SQL query is displayed in a read-only text box, dynamically updated as parameters are configured.
  - A "Run Query" button sends the query to the server for execution.

---

### 6. Query Results

- Description:
  The user views the results of the executed query.

- Functional Flow:
  - If no data is returned, a "No data" message is shown.
