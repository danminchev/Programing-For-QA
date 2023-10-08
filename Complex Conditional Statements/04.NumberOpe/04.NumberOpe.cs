double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
string mathOperator = Console.ReadLine();

if (mathOperator == "+")
{
    double result = num1 + num2;
    Console.WriteLine($"{num1} + {num2} = {result:f2}");
}
else if (mathOperator == "-")
{
    double result = num1 - num2;
    Console.WriteLine($"{num1} - {num2} = {result:f2}");
}
else if (mathOperator == "*")
{
    double result = num1 * num2;
    Console.WriteLine($"{num1} * {num2} = {result:f2}");
}
else if (mathOperator == "/")
{
    double result = num1 / num2;
    Console.WriteLine($"{num1} / {num2} = {result:f2}");
}
