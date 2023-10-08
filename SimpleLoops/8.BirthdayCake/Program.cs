using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace _8.BirthdayCake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wight = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int piecesOfCount = wight * height;
            string command;
            while(true)
            {
                command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{piecesOfCount} pieces are left.");
                    break;
                }
                int piecesTotake = int.Parse(command);
                if (piecesTotake >piecesOfCount)
                {
                    Console.WriteLine($"No more cake left! You need {piecesTotake - piecesOfCount} pieces more.");
                    break;
                }
                piecesOfCount -= piecesTotake;
                if (piecesOfCount < 0)
                {
                    Console.WriteLine($"{piecesOfCount} pieces are left.");
                    break;
                }
            }
           
            
        }
    }
}