namespace Multiple_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("John", "Doe");
        employee.Pay();
        employee.Report();
        
        ((IPayable)employee).Test();
        ((IReportable)employee).Test();
        
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}