﻿int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

if (number1 > number2 && number2 > number3)
    Console.WriteLine(number1);
else if (number1 < number2 && number2 < number3) 
    Console.WriteLine(number3);
else if (number1 < number2 && number2 > number3)
    Console.WriteLine(number2);
