using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace _03.OldBooks
{
    internal class Program
    {
        static void Main_(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            bool bookFound = false;
            int bookSearched = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "No More Books")
                {
                    break;
                }

                if (input == favoriteBook)
                {
                    bookFound = true;
                    break;
                }
                bookSearched++;
            }
            if (bookFound)
            {
                Console.WriteLine($"You checked {bookSearched} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookSearched} books.");
            }
        }
        static void Main__(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int chekcedBooks = 0;

            while (favoriteBook != currentBook && currentBook != "No More Books") 
            {
                chekcedBooks++;
                currentBook = Console.ReadLine();
            }

            if (currentBook == favoriteBook)
            {
                Console.WriteLine($"You checked {chekcedBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {chekcedBooks} books.");
            }

        }

        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int chekcedBooks = 0;
            bool bookFound = false;

            while (currentBook != "No More Books")
            {
                if (favoriteBook == currentBook)
                {
                    bookFound = true;
                    break;
                }
                chekcedBooks++;
                currentBook = Console.ReadLine();
               
            }
            if (bookFound)
            {
                Console.WriteLine($"You checked {chekcedBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {chekcedBooks} books.");
            }

        }
    }
}