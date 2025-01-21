# Scenarios for Interaction in SQL Query Builder

This document describes various scenarios of user interaction with SQL Query Builder, including possible errors and approaches to solving them. The goal is to ensure the program works correctly in different cases and provides logical behavior for the user.

---

## Scenario 1: Working with a Single Table

- Description:
  The user selects only one table, such as `Customers`.

- Program Logic: 
  - The program displays a list of columns from the selected table.  
  - A simple SQL query is generated:  
    ```sql
    SELECT CustomerID, CustomerName, ContactNumber
    FROM Customers;
    ```  
  - The user can add filters, sorting, and select specific columns.  

- Expected Result:
  The program correctly displays data from the selected single table.

---

## Scenario 2: Working with Multiple Related Tables

- Description:
  The user selects two or more tables that are related via a foreign key, such as `Customers` and `Orders` (related through `CustomerID`).

- Program Logic:
  - The program automatically identifies the relationship via the foreign key.  
  - A default join type (`INNER JOIN`) is suggested, but the user can choose another type (`LEFT JOIN`, `RIGHT JOIN`, etc.).  
  - An SQL query is generated:  
    ```sql
    SELECT Customers.CustomerName, Orders.OrderID, Orders.OrderDate
    FROM Customers
    INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
    ```  
  - If the user removes one of the tables, all relationships with that table are removed, and the program notifies the user.  

- Expected Result:
  The program displays data from related tables. If a table is removed, its relationships are also removed, and the interface reflects this.

---

## Scenario 3: Working with Unrelated Tables

- Description:
  The user selects tables that do not have a clear relationship (e.g., `Customers` and `Products`).

- Program Logic:
  - The program notifies the user that the tables are unrelated and offers options:  
    - Specify the relationship manually.  
    - Use a `CROSS JOIN` if no relationship is specified.  
  - An SQL query is generated:  
    ```sql
    SELECT Customers.CustomerName, Products.ProductName
    FROM Customers
    CROSS JOIN Products;
    ```  

- Expected Result:
  The program displays either the Cartesian product of the tables or data based on the manually specified relationship.

---

## Scenario 4: Removing Tables Used in Parameters

- Description 
  The user removes a table that is used in filters, sorting, or other parameters.

- Program Logic:
  - All parameters related to the removed table (filters, sorting, grouping) are automatically removed or reset.  
  - The user is notified:  
    *"Parameters related to the removed table have been cleared."*  
  - If the table is used in relationships, those relationships are also removed, with a notification:  
    *"Relationships with the removed table have been cleared."*  

- Expected Result:
  The program updates and removes all parameters and relationships related to the removed table.

---

## Scenario 5: Removing a Key Table in a Relationship Chain

- Description:
  The user removes a table that serves as a central node for multiple related tables (e.g., `A -> B -> C`, where `B` is removed).

- Program Logic:
  - The program checks if a direct relationship between the remaining tables can be established.  
  - If no direct relationship is possible, all parameters and relationships involving the removed table are cleared.  
  - The user is notified:  
    *"Removing this table resulted in the removal of all dependent parameters and relationships."*  

- Expected Result:
  The program removes all parameters and relationships related to the removed table and informs the user about the changes.

---

## Scenario 6: Incorrect Table Removal

- Description:
  The user attempts to remove a table without first removing the parameters that use it.

- Program Logic:
  - The program displays a warning before removal:  
    *"Removing this table will result in the removal of all related parameters (sorting, filters, relationships). Are you sure you want to continue?"*  
  - After confirmation, the parameters and relationships are removed.  

- Expected Result:
  The user is warned about the consequences of removing the table, and changes are applied only after confirmation.

---

## Scenario 7: Working with Tables Without Foreign Keys

- Description:
  Tables are logically related, but foreign keys are not defined in the database.

- Program Logic:
  - The program prompts the user to manually specify the relationship condition (e.g., `Customers.CustomerID = Orders.CustomerID`).  
  - After specifying the condition, an SQL query is generated:  
    ```sql
    SELECT Customers.CustomerName, Orders.OrderID
    FROM Customers
    INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
    ```  

- Expected Result:
  The program correctly displays data based on the manually specified relationship condition.

---

This document outlines the key scenarios for using SQL Query Builder and handling data in various situations. The document can be expanded with additional scenarios or details as necessary.
