int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

for (int firstDigi = 2; firstDigi <= max1; firstDigi += 2)
{
    for (int secondDigit = 1; secondDigit <= max2; secondDigit += 1)
    {
        for (int thirdDigi = 2; thirdDigi <= max3; thirdDigi += 2)
        {
           if (secondDigit == 2 ||secondDigit == 3 || secondDigit == 5 || thirdDigi == 7)
           {
                Console.WriteLine($"{firstDigi}{secondDigit}{thirdDigi}");
           }  
        }
    }
}
