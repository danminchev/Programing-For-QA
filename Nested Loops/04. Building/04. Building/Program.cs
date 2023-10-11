int floorsCount = int.Parse(Console.ReadLine());
int roomCount = int.Parse(Console.ReadLine());

for (int floors = floorsCount; floors >= 1; floors --)
{
  for(int room = 0; room < roomCount; room ++)
    {
        if (floors == floorsCount)
        {
            Console.Write($"L{floors}{room} ");
        }
        else if (floors % 2 == 0) 
        {
            Console.Write($"O{floors}{room} ");
        }
        else
        {
            Console.Write($"A{floors}{room} ");
        }
    }
    Console.WriteLine();
}