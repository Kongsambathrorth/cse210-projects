// Program.cs

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System");
        Console.WriteLine("======================\n");

        // --- Order 1 (USA Customer) ---
        Console.WriteLine("--- Order 1 ---");

        // 1. Create Address and Customer
        Address address1 = new Address("123 Main St", "Anahem", "CA", "USA");
        Customer customer1 = new Customer("KOng Sambath", address1);

        // 2. Create an Order
        Order order1 = new Order(customer1);

        // 3. Create and Add Products
        Product product1A = new Product("Laptop", "PROD-001", 1200.50, 1);
        Product product1B = new Product("Mouse", "PROD-002", 25.00, 2);
        order1.AddProduct(product1A);
        order1.AddProduct(product1B);

        // 4. Display Results for Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():0.00}\n");


        // --- Order 2 (International Customer) ---
        Console.WriteLine("--- Order 2 ---");

        // 1. Create Address and Customer
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // 2. Create an Order
        Order order2 = new Order(customer2);

        // 3. Create and Add Products
        Product product2A = new Product("Keyboard", "PROD-003", 75.99, 1);
        Product product2B = new Product("Webcam", "PROD-004", 49.50, 1);
        Product product2C = new Product("USB Hub", "PROD-005", 15.00, 3);
        order2.AddProduct(product2A);
        order2.AddProduct(product2B);
        order2.AddProduct(product2C);
        
        // 4. Display Results for Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():0.00}");
    }
}
