int countStudents = int.Parse(Console.ReadLine());

double totalGrade = 0;

for (int i = 0; i < countStudents; i++)
{
    double grate = double.Parse(Console.ReadLine());

    totalGrade += grate;
}
double averageGrade = totalGrade / countStudents;

Console.WriteLine($"{averageGrade:F2}");

