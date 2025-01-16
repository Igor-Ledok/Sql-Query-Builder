# Handling Multiple Tables in the SQL Query Builder

This document describes the possible scenarios of how the **SQL Query Builder** application interacts with multiple tables, including potential issues and approaches to solving them. The goal is to ensure correct interaction with the database in various scenarios and provide a logical and clear behavior for the user.

---

## Scenarios for Table Interaction

### **Scenario 1: Single Table**
- **Description:** The user selects only one table, such as `Customers`.
- **Program Logic:**
  - The program displays a list of columns from the selected table.
  - A simple SQL query is generated:
    ```sql
    SELECT CustomerID, CustomerName, ContactNumber
    FROM Customers;
    ```
  - The user can add filters, sorting, and select specific columns.
- **Expected Result:** A table with data from the single selected table is displayed correctly.

---

### **Scenario 2: Two Related Tables**
- **Description:** The user selects two tables that have a clear relationship via a foreign key, such as `Customers` and `Orders` (related through `CustomerID`).
- **Program Logic:**
  - The program automatically identifies the relationship between the tables using the foreign key.
  - The user can choose the type of join (`INNER JOIN`, `LEFT JOIN`, etc.).
  - A query is generated:
    ```sql
    SELECT Customers.CustomerName, Orders.OrderID, Orders.OrderDate, Orders.TotalAmount
    FROM Customers
    INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
    ```
  - The user can select columns from both tables and add filters and sorting.
- **Expected Result:** A combined table with data from the two related tables is displayed correctly.

---

### **Scenario 3: Two Unrelated Tables**
- **Description:** The user selects two tables that do not have a clear relationship, such as `Customers` and `Products`.
- **Program Logic:**
  - The program informs the user that the tables are unrelated and suggests manually specifying a join condition (via the `ON` clause).
  - If the user does not specify a join condition, a `CROSS JOIN` is used:
    ```sql
    SELECT Customers.CustomerName, Products.ProductName
    FROM Customers
    CROSS JOIN Products;
    ```
- **Expected Result:** Either a Cartesian product of the two tables is displayed, or a table based on the manually specified join condition.

---

### **Scenario 4: More Than Two Related Tables**
- **Description:** The user selects three or more related tables, such as `Customers`, `Orders`, and `OrderDetails`.
- **Program Logic:**
  - The program automatically determines the relationships through a chain of foreign keys:
    - `Customers.CustomerID -> Orders.CustomerID`
    - `Orders.OrderID -> OrderDetails.OrderID`
  - A query is generated:
    ```sql
    SELECT Customers.CustomerName, Orders.OrderID, OrderDetails.ProductID, OrderDetails.Quantity
    FROM Customers
    INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID
    INNER JOIN OrderDetails ON Orders.OrderID = OrderDetails.OrderID;
    ```
- **Expected Result:** A table with combined data from all related tables is displayed correctly.

---

### **Scenario 5: Unrelated Tables in the List**
- **Description:** The user selects several tables, some of which are related while others are not, such as `Customers`, `Orders`, and `Suppliers`.
- **Program Logic:**
  - The program generates an SQL query for the related tables (`Customers` and `Orders`) and informs the user that `Suppliers` is unrelated.
  - A query is generated:
    ```sql
    SELECT Customers.CustomerName, Orders.OrderID, Orders.OrderDate
    FROM Customers
    INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
    ```
- **Expected Result:** A table with data from the related tables is displayed, while the unrelated tables are excluded with a clear warning.

---

### **Scenario 6: More Than Two Unrelated Tables**
- **Description:** The user selects three or more tables that are not related, such as `Customers`, `Products`, and `Suppliers`.
- **Program Logic:**
  - The program suggests either manually specifying join conditions or using `CROSS JOIN`:
    ```sql
    SELECT Customers.CustomerName, Products.ProductName, Suppliers.SupplierName
    FROM Customers
    CROSS JOIN Products
    CROSS JOIN Suppliers;
    ```
- **Expected Result:** A table with the Cartesian product of all rows from the selected tables is displayed.

---

### **Scenario 7: Tables Without Foreign Keys**
- **Description:** The tables are logically related, but the foreign key is not defined in the database.
- **Program Logic:**
  - The program suggests the user manually specify the join condition (e.g., `Customers.CustomerID = Orders.CustomerID`).
  - A query is generated:
    ```sql
    SELECT Customers.CustomerName, Orders.OrderID
    FROM Customers
    INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
    ```
- **Expected Result:** A table is displayed based on the manually specified join condition.

---

This document outlines the key scenarios and approaches for handling multiple tables in the **SQL Query Builder**. If necessary, it can be extended with additional details or examples.
