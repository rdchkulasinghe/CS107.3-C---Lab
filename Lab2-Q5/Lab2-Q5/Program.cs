using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q5
{
    class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; private set; }

        public LibraryBook(string title, string author)
        {
            Title = title;
            Author = author;
            Available = true; 
        }

        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' by {Author} is not available for borrowing.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook("Robinson Crusoe", "Daniel Defoe");
            LibraryBook book2 = new LibraryBook("Gulliver Travels", "Jonathan Swift");
            LibraryBook book3 = new LibraryBook("Clarissa", "Samuel Richardson");

            book1.BorrowBook();
            book2.BorrowBook();
            book1.BorrowBook();

            Console.WriteLine("\nLibrary Status:");
            Console.WriteLine($"Book '{book1.Title}' by {book1.Author} - Available: {book1.Available}");
            Console.WriteLine($"Book '{book2.Title}' by {book2.Author} - Available: {book2.Available}");
            Console.WriteLine($"Book '{book3.Title}' by {book3.Author} - Available: {book3.Available}");

            Console.ReadLine(); 
        }
    }

}
