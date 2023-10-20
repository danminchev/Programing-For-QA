int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secontArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

bool isEqual = true;

for (int index = 0; index <= firstArray.Length - 1; index++)
{
    if (firstArray[index] != secontArray[index])
    {
        isEqual = false;
        Console.WriteLine("Arrays are not identical.");
        break;

    }
}
if (isEqual)
Console.WriteLine("Arrays are identical.");

