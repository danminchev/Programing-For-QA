using System;

class Program
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());

       if (number1 == 0 || number2 == 0 || number3 == 0)
        {
            Console.WriteLine("zero");
        }
       else if (number1 < 0 && number2 < 0 && number3 > 0)
        {
            Console.WriteLine("positive");
        }
       else if (number1 < 0 && number2 > 0 && number3 < 0)
        {
            Console.WriteLine("positive");
        }
        else if (number1 > 0 && number2 < 0 && number3 < 0)
        {
            Console.WriteLine("positive");
        }
        else
        {
            Console.WriteLine("negative" );
        }

    }
}

