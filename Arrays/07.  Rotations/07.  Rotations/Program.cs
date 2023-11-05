int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int N = int.Parse(Console.ReadLine());

int length = numbers.Length;

for (int rotation = 0; rotation < N; rotation++)
{
    int lastNumber = numbers[length - 1];

    for (int i = length - 1; i > 0; i--)
    {
        numbers[i] = numbers[i - 1];
    }

    numbers[0] = lastNumber;
}

Console.WriteLine(string.Join(", ", numbers));