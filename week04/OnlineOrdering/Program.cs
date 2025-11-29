using System;

class Program
{
    static void Main(string[] args)
    {
        Address add1 = new Address("123 Apple St", "Dallas", "TX", "USA");
        Customer cus1 = new Customer("John Doe", add1);

        Order order1 = new Order(cus1);
        order1.AddProduct(new Product("Laptop", "A100", 900, 1));
        order1.AddProduct(new Product("Mouse", "B200", 25, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");


        Address add2 = new Address("45 Sunrise Ave", "Toronto", "ON", "Canada");
        Customer cus2 = new Customer("Emma Smith", add2);

        Order order2 = new Order(cus2);
        order2.AddProduct(new Product("Camera", "C300", 500, 1));
        order2.AddProduct(new Product("Tripod", "D400", 75, 1));
        order2.AddProduct(new Product("SD Card", "E500", 20, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}