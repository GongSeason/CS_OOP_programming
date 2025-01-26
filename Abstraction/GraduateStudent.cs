namespace Abstraction;

public class GraduateStudent:Student
{
    public string ResearchArea { get; set; }
    
    public override void DisplayInformation()
    {
        Console.WriteLine($"Graduate Student\nName:{Name}\nAge:{Age}\nRearch Area:{ResearchArea}");
        
    }
}