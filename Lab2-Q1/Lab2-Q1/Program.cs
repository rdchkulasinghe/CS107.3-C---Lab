using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q1
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            
            myBook.Title = "The Adventures of Tom Sawyer";
            myBook.Author = "Mark Twain";
;

            Console.WriteLine("Book Title: " + myBook.Title);
            Console.WriteLine("Author: " + myBook.Author);

            Console.ReadLine(); 
        }
    }

}
