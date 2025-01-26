//Using abstraction to work with different types of students

using Abstraction;

Student undergraduateStudent = new UndergraduateStudent()
{
    Name = "Sahana Bhat",
    Age = 18,
    Major = "Computer Science"
};

Student graduateStudent = new GraduateStudent()
{
    Name = "Ritu Verma",
    Age = 20,
    ResearchArea = "AI"
};

undergraduateStudent.WelcomeMessage();
undergraduateStudent.DisplayInformation();
Console.WriteLine("\n------------------\n");
graduateStudent.WelcomeMessage();
graduateStudent.DisplayInformation();
