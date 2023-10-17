static void PrintGrade(double gradeParameter)
{
    if (gradeParameter >= 2.00 && gradeParameter <= 2.99)
    {
        Console.WriteLine("Fail");
    }
    else if (gradeParameter >= 3.00 && gradeParameter <= 3.49)
    {
        Console.WriteLine("Average");
    }
    else if (gradeParameter >= 3.50 && gradeParameter <= 4.49)
    {
        Console.WriteLine("Good");
    }
    else if (gradeParameter >= 4.50 && gradeParameter <= 5.49)
    {
        Console.WriteLine("Very good");
    }
    else
    {
        Console.WriteLine("Excellent");
    }
}

double grade = double.Parse(Console.ReadLine());

PrintGrade(grade);