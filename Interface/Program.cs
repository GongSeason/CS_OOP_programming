// See https://aka.ms/new-console-template for more information

using Interface;

ICustomer customer = new Customer(1, "Rita", "B", "Rita.b@example.com", "123-456-789",
    new DateTime(1985, 5, 15), "123 Main Street");

Console.WriteLine(customer.GetFullName());


Customer customer2 = new Customer(2, "Roy", "A", "Roy.b@example.com", "123-456-789",
    new DateTime(1985, 5, 15), "123 Main Street"); 
customer2.PrintCusomerInfo();


