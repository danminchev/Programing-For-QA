using System.ComponentModel.Design;

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int num4 = int.Parse(Console.ReadLine());
int num5 = int.Parse(Console.ReadLine());

if (num1 > num2)  
    Console.WriteLine(num1);
else if (num2 > num3)  
    Console.WriteLine(num2);
else if (num3 > num4)  
    Console.WriteLine(num3);
else if (num4 > num5)  
    Console.WriteLine(num4);
else 
    Console.WriteLine(num5);

