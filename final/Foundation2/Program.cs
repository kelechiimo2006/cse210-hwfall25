using System;

class Program
{
    static void Main(string[] args)
    {
        Address samuelsAddress = new Address("650 Spring St.", "Rexburg", "Idaho", "UK");
        Customer customerSamuel = new Customer("Samuel", samuelsAddress);
        Product productA1 = new Product("Towel", 1, 5, 10);
        Product productA2 = new Product("Apple", 3, 2, 5);
        List<Product> samuelsProducts = [productA1, productA2];
        Order samuelsOrder = new Order(samuelsProducts, customerSamuel);
        Console.WriteLine($"The total cost of your order + shipping is: ${samuelsOrder.CalculateTotalCost()}");
        samuelsOrder.DipslayPackingLabel();
        samuelsOrder.DisplayShippingLabel();

        Console.WriteLine("");

        Address address2 = new Address("649 East", "Orem", "Utah", "USA");
        Customer customer2 = new Customer("Gary", address2);
        Product productB1 = new Product("Pen", 1, 5, 10);
        Product productB2 = new Product("Orange", 2, 2, 5);
        Product productB3 = new Product("Car", 3, 4, 2);
        List<Product> products2 = [productB1, productB2, productB3];
        Order order2 = new Order(products2, customer2);
        Console.WriteLine($"The total cost of your order + shipping is: ${order2.CalculateTotalCost()}");
        order2.DipslayPackingLabel();
        order2.DisplayShippingLabel();

        Console.WriteLine("");

        Address address3 = new Address("500 North", "Layton", "Utah", "USA");
        Customer customer3 = new Customer("Cameron", address3);
        Product productC1 = new Product("Pencil", 1, 3, 10);
        Product productC2 = new Product("Gum", 2, 4, 4);
        Product productC3 = new Product("Magazine", 3, 2, 4);
        List<Product> products3 = [productC1, productC2, productC3];
        Order order3 = new Order(products3, customer3);
        Console.WriteLine($"The total cost of your order + shipping is: ${order3.CalculateTotalCost()}");
        order3.DipslayPackingLabel();
        order3.DisplayShippingLabel();








    }
}