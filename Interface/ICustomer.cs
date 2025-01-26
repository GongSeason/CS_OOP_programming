namespace Interface;

public interface ICustomer
{
    int Id { get; set; }
    string Name { get; set; }
    string LastName { get; set;}
    string Email { get; set;}
    string PhoneNumber { get; set;}
    DateTime DateOfBirth { get;}
    string Address { get; set;}
    
    void UpdateContactInfo(string email, string phoneNumber);
    string GetFullName();
    int GetAge();
}