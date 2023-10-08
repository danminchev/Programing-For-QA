namespace ValidTriangle
{
    internal class ValidTriangle
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());  
            
            if (a + b <= c )
                Console.WriteLine("Invalit Triangle");
            else if (c + b <= a)
                Console.WriteLine("Invalit Triangle");
            else if (a + c <= b)
                Console.WriteLine("Invalit Triangle");
            else
                Console.WriteLine("Valid Triangle");

        }
    }
}