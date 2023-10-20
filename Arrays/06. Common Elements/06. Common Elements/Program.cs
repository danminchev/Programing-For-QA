int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); 
int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int sum = 0;

foreach (int index in firstArray)
{
    foreach (int index2 in secondArray)
    {
        if (index == index2)
        {
            Console.Write(index + " ");
            break;
        }
    }
}