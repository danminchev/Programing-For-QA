namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue; 
            int sumOfAll = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                
                if (numbers > maxNumber)               
                    maxNumber = numbers;
                   
                sumOfAll += numbers;
            }


            sumOfAll -= maxNumber;

            if (sumOfAll == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOfAll}");
            }
            else
            {
                int diff = Math.Abs(maxNumber - sumOfAll);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}