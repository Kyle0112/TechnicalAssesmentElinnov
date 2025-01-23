# Inventory Management System

This is a simple console-based inventory management system built using C#. The application allows users to manage products in a retail store's inventory by adding, removing, updating, and viewing products, as well as calculating the total value of the inventory.

## Features

1. **Add Product**: Add a new product with a unique ID, name, quantity in stock, and price.
2. **Remove Product**: Remove an existing product by its ID.
3. **Update Product Quantity**: Update the quantity of an existing product by its ID.
4. **List Products**: View all products in the inventory, including their ID, name, quantity, and price (formatted in USD).
5. **Get Total Inventory Value**: Calculate and display the total value of the inventory, formatted in USD.
6. **Exit**: Exit the application.

## File Structure

```
|-- TechnicalAssesmentElinnov
    |-- Models
        |-- Product.cs
        |-- InventoryManager.cs
    |-- Views
        |-- ConsoleView.cs
    |-- Controller
        |-- Program.cs
```

### File Descriptions:
- **Product.cs**: Defines the `Product` class with properties `ProductId`, `Name`, `QuantityInStock`, and `Price`.
- **InventoryManager.cs**: Manages the inventory with methods to add, remove, update, and list products, as well as calculate the total inventory value.
- **ConsoleView.cs**: Handles user input and output, including displaying menus, capturing product details, and formatting output.
- **Program.cs**: The entry point of the application. It integrates the `InventoryManager` and `ConsoleView` classes to provide functionality to the user.

## Usage

1. Clone or download the repository to your local machine.
2. Open the project in Visual Studio.
3. Build the solution to ensure all dependencies are resolved.
4. Run the application.

### Menu Options

When the application runs, you will be presented with the following menu:
```
Inventory Management System
1. Add Product
2. Remove Product
3. Update Product Quantity
4. List Products
5. Get Total Inventory Value
6. Exit
```

- Enter the number corresponding to your desired action.
- Follow the prompts to perform the selected action.
- To exit the application, choose option `6`.

### Example Input/Output

#### Adding a Product:
```
Enter Product ID: 1
Enter Product Name: Laptop
Enter Quantity in Stock: 5
Enter Product Price: 999.99
```

#### Listing Products:
```
Current Inventory:
ID: 1, Name: Laptop, Quantity: 5, Price: $999.99
```

#### Total Inventory Value:
```
Total Inventory Value: $4,999.95
```

## Constraints

- Product IDs must be positive integers.
- Prices must be non-negative real numbers.
- Quantities must be non-negative integers.
- Inventory starts empty.

## Notes

- All prices and the total inventory value are displayed in US dollars.
- The application includes basic error handling for invalid input (e.g., duplicate IDs, product not found, etc.).


## License

This project is open-source and available for personal and educational use. Feel free to modify and adapt it to your needs.

