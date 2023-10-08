int number = int.Parse(Console.ReadLine());
int biggestNumber = int.MinValue;

//for (int i = 0; i < number; i++)
//{
//    int num = int.Parse(Console.ReadLine());
   
//    if(num > biggestNumber)
//    {
//        biggestNumber = num;
//    }
//}
//Console.WriteLine(biggestNumber);

while (number > 0)
{
    int num = int.Parse(Console.ReadLine());
    if (num > biggestNumber)
    {
        biggestNumber = num;
    }
    number--;
}
Console.WriteLine(biggestNumber);