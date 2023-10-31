int[] inputArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


int middleRightElementIndex = inputArray.Length / 2;
int middleLeftElementIndex = middleRightElementIndex - 1;

double middleElementAverageg = (inputArray[middleRightElementIndex] + inputArray[middleLeftElementIndex]) / 2.0;

Console.WriteLine($"{middleElementAverageg:F2}");

