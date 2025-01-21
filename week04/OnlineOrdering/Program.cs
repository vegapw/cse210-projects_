using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("2210 Unknown Ur.", "Unknown City", "ID", "USA");
        Customer c1 = new Customer("Shannon",a1);
        Order o1 = new Order(c1);
        Address a2 = new Address("Carrera 10 # 20 - 80", "Sabaneta", "Antioquia", "Colombia");
        Customer c2 = new Customer("Frank",a2);
        Order o2 = new Order(c2);
        Product p1 = new Product("Phone XX Pro M", 123456, 1099.00, 2);
        Product p2 = new Product("Watch Series X", 123457, 399.00, 2);
        Product p3 = new Product("Dron Ultra XX", 100345, 799.00, 1);
        Product p4 = new Product("Gomin Watch Fen X Solar Sapphire Black Case", 100457, 1099.00, 1);
        Product p5 = new Product("MBook Pro X4 Max", 100458, 3999.00, 1);
        o1.AddProductToOrder(p1);
        o1.AddProductToOrder(p2);
        o2.AddProductToOrder(p3);
        o2.AddProductToOrder(p4);
        o2.AddProductToOrder(p5);

        Console.WriteLine($"Order 1 Packing Label:\n{o1.PackingLabel()}");
        Console.WriteLine($"Order 1 Shipping Label:\n{o1.ShippingLabel()}");
        Console.WriteLine($"Order 1 Total Cost: ${o1.CalculateTotalCost()}\n");
        Console.WriteLine($"Order 2 Packing Label:\n{o2.PackingLabel()}");
        Console.WriteLine($"Order 2 Shipping Label:\n{o2.ShippingLabel()}");
        Console.WriteLine($"Order 2 Total Cost: ${o2.CalculateTotalCost()}\n");
    }
}