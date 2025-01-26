namespace Interface;

public class Customer : ICustomer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }

    public Customer(int id, string name, string lastName, string email, string phoneNumber, DateTime dateOfBirth,
        string address)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        DateOfBirth = dateOfBirth;
        Address = address;
    }


    public void UpdateContactInfo(string email, string phoneNumber)
    {
        Email = email; 
        PhoneNumber = phoneNumber;
    }

    public string GetFullName()
    {
        return $"{Name} {LastName}";
    }

    public int GetAge()
    {
        var today = DateTime.Today;
        var age = today.Year - DateOfBirth.Year;
        if (DateOfBirth.Date > today.AddYears(-age)) age--;
        return age;
    }

    public void PrintCusomerInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {GetFullName()}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Age: {GetAge()}");
        Console.WriteLine($"Address: {Address}");
    }
}