int stopeNumber = int.Parse(Console.ReadLine());
int previousNumber = int.Parse(Console.ReadLine());

while (true)
{
    int countNumbers = int.Parse(Console.ReadLine());

    if (stopeNumber == countNumbers)
        break;
    else
        previousNumber = countNumbers;
}
//double bonus = previousNumber * 0.2;
//double result = previousNumber + bonus;
double result = previousNumber * 1.2;

Console.WriteLine(result);






