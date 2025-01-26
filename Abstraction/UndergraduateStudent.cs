namespace Abstraction;

public class UndergraduateStudent: Student
{
    public string Major { get; set; }
    
    public override void DisplayInformation()
    {
       Console.WriteLine($"Undergraduate Student\nName: {Name}\nAge: {Age}\nMajor: {Major}");
    }
}