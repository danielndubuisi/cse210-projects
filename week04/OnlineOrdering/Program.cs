using System;

class Program
{
    static void Main(string[] args)
    {
        // set customer1 information
        Address customerOneAddress = new Address("Toyin St.", "Ikeja", "Lagos", "Nigeria");
        // create customer
        Customer customer1 = new Customer("Daniel Ndubuisi", customerOneAddress);
        // create product list
        List<Product> customerOneProducts = [];

        // create and add products
        Product c1p1 = new Product("Laptop", "P001", 896.59, 1);
        Product c1p2 = new Product("Phone", "P002", 480.70, 2);

        // add products to list   
        customerOneProducts.Add(c1p1);
        customerOneProducts.Add(c1p2); 

        // create order
        Order order1 = new Order(customer1, customerOneProducts);

        // set customer2 information
        Address customerTwoAddress = new Address("Main St.", "Los Angeles", "California", "USA");  
        // create customer
        Customer customer2 = new Customer("John Mayer", customerTwoAddress);
        // create product list
        List<Product> customerTwoProducts = [];

        // create and add products
        Product c2p1 = new Product("Monitor", "P004", 200.00, 1);
        Product c2p2 = new Product("Keyboard", "P005", 50.00, 2);
        Product c2p3 = new Product("Mouse", "P006", 25.00, 3);

        // add products to list
        customerTwoProducts.Add(c2p1);
        customerTwoProducts.Add(c2p2);
        customerTwoProducts.Add(c2p3);

        // create order
        Order order2 = new Order(customer2, customerTwoProducts);

        // add orders to list
        List<Order> orders = [order1, order2];

        Console.WriteLine("-------------------------------------------------------------");
        // loop through each order and print the order details
        foreach (Order order in orders)
        {
            // print order details
            Console.WriteLine($"ORDER {orders.IndexOf(order) + 1} {order.GetPackingLabel()}\n{order.GetShippingLabel()}\nTotal Cost (plus shipping): ${order.CalculateTotalOrder()}\n");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}