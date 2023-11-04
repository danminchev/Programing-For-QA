List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
    
int selection = int.Parse(Console.ReadLine());

numbers.Reverse();

List<int> intSelection = numbers.Take(selection).ToList();

double avarege = intSelection.Average();

Console.WriteLine($"{avarege:F2}");

//int[] numbers = Console.ReadLine()
//    .Split()
//    .Select(int.Parse)
//    .ToArray();

//int N = int.Parse(Console.ReadLine());

////if (N > numbers.Length)
////{
////    Console.WriteLine("N is larger than the array length.");
////    return;
////}

//double sum = 0;

//for (int i = numbers.Length - N; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}

//double average = sum / N;

//Console.WriteLine($"{average:f2}");













