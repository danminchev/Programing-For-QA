static int FindGreaterNumber(int number1, int number2)
{
   if (number1 > number2)
    {
       return number1;
    }
    else
    {
        return number2;
    }
}
static char FindGreaterChar(char symbol1, char symbol2)
{
    if (symbol1 > symbol2)
    {
        return symbol1;
    }
    else
    {
        return symbol2;
    }
}
static string FindGreaterString(string str1, string str2)
{
    if (str1.CompareTo(str2) > 0)
    {
        return str1;
    }
    else
    {
        return str2;
    }
}

string valueType = Console.ReadLine();

if (valueType == "int" )
{
    int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());

    Console.WriteLine(FindGreaterNumber(number1,number2));
}
else if (valueType == "char")
{
    char symbol1 = char.Parse(Console.ReadLine());
    char symbol2 = char.Parse(Console.ReadLine());

    Console.WriteLine(FindGreaterChar(symbol1, symbol2));
}
else if (valueType == "string")
{
    string str1 = Console.ReadLine();
    string str2 = Console.ReadLine();

    Console.WriteLine(FindGreaterString(str1, str2));
}

