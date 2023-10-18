﻿//string password = Console.ReadLine();

//bool isValidLength = password.Length >= 6 && password.Length <= 10;
//bool isValidContent = CheckContent(password);
//bool isValidCountDigits = CheckCountDigit(password);

//if (isValidLength && isValidContent && isValidCountDigits)
//{
//    Console.WriteLine("Password is valid");
//}
//else
//{
//    if (!isValidLength)
//    {
//        Console.WriteLine("Password must be between 6 and 10 characters");
//    }
//    if (!isValidContent)
//    {
//        Console.WriteLine("Password must consist only of letters and digits");
//    }
//    if (!isValidCountDigits)
//    {
//        Console.WriteLine("Password must have at least 2 digits");
//    }
//}

//static bool CheckContent(string password)
//{
//    for (int position = 0; position < password.Length; position++)
//    {
//        char symbol = password[position];
//        if (!char.IsLetter(symbol) && !char.IsDigit(symbol))
//        {
//            return false;
//        }
//    }
//    return true;
//}

//static bool CheckCountDigit(string password)
//{
//    int count = 0;
//    for (int position = 0; position < password.Length; position++)
//    {
//        char symbol = password[position];
//        if (char.IsDigit(symbol))
//        {
//            count++;
//        }
//    }
//    return count >= 2;
//}
string password = Console.ReadLine();

bool isValidLength = password.Length >= 6 && password.Length <= 10;

bool isValidContent = CheckContent(password);

bool isValidCountDigits = CheckCountDigit(password);

if (isValidLength == true && isValidContent == true && isValidCountDigits == true)
{
    Console.WriteLine("Password is valid");
}
else
{
    if (isValidLength == false)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }
    if (isValidContent == false)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }
    if (isValidCountDigits == false)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}
static bool CheckContent(string password)
{
    for (int position = 0; position <= password.Length - 1; position++)
    {
        char symbol = password[position];
        if (char.IsLetterOrDigit(symbol) == false)
        {
            return false;
        }
    }
    return true;
}
static bool CheckCountDigit(string password)
{
    int count = 0;
    for (int position = 0; position <= password.Length - 1; position++)
    {
        char symbol = password[position];
        if (char.IsDigit(symbol) == true)
        {
            count++;
        }
    }
    return count >= 2;
}


