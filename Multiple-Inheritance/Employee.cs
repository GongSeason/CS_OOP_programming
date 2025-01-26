namespace Multiple_Inheritance;

public class Employee : IPayable, IReportable
{
    public string Name { get; set; }
    public string Department { get; set; }

    public Employee(string name, string department)
    {
        Name = name;
        Department = department;
    }

    public void Pay()
    {
       Console.WriteLine($"Processing salary for {Name} in {Department} department ");
    }

    void IPayable.Test()
    {
        Console.WriteLine("Test method from IPayable");
    }

    public void Report()
    {
       Console.WriteLine($"Generating report for {Name} in {Department} department");
    }

    void IReportable.Test()
    {
        Console.WriteLine("Test method from IReportable");
    }
}