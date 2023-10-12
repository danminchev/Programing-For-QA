string destination = Console.ReadLine();

while (destination != "End")
{
    double neededSum = double.Parse(Console.ReadLine());
    double sum = 0;

    while (neededSum > sum)
    {
        double sumToBeAdded = double.Parse(Console.ReadLine());
        sum += sumToBeAdded;
        Console.WriteLine($"Collected: {sum:F2}");
    }

    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}
