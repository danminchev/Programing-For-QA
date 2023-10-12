string command = Console.ReadLine();

while (command != "End")
{
    int number = int.Parse(command);
    int sum = 0;

    while (number > 0)
    {
        int lastNum = number % 10;
        number = number / 10;
        sum += lastNum;
    }
    Console.WriteLine($"Sum of digits = {sum}");

    command = Console.ReadLine();
}    
Console.WriteLine("Goodbye");
