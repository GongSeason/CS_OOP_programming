namespace Abstraction;

public abstract class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    //Abstract method for displaying student information
    public abstract void DisplayInformation();

    // Non-abstract method
    public void WelcomeMessage()
    {
        Console.WriteLine("Welcome to student management system");
    }
}