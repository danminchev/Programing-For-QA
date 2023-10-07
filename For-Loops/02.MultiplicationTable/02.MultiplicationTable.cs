int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    int result = number * i;
//    Console.WriteLine($"{number} x {i} = {result}");
//}
int multipler = 1;
while (multipler <= 10)
{
    int result = number * multipler;
    Console.WriteLine($"{number} x {multipler} = {result}");
    multipler++;
}