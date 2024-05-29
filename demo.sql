-- Create a table for 5 products with product names and prices
CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(50),
    product_price DECIMAL(10, 2)
);
-- Insert 5 products into the table
INSERT INTO products VALUES (1, 'Apple', 1.00);
INSERT INTO products VALUES (2, 'Banana', 0.5);
INSERT INTO products VALUES (3, 'Orange', 0.8);
INSERT INTO products VALUES (4, 'Pineapple', 2.5);
INSERT INTO products VALUES (5, 'Watermelon', 3.0);

-- Path: demo.sql
-- Create a table for 3 customers with customer names and emails
CREATE TABLE customers (
    customer_id INT PRIMARY KEY,
    customer_name VARCHAR(50),
    customer_email VARCHAR(50)
);
-- Insert 3 customers into the table
INSERT INTO customers VALUES (1, 'Alice', '