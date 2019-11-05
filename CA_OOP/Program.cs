/*************************
 * NAME: Art Mc Goldrick *
 * DATE: 5/11/2019       *
 * DESC: Book            *
 *************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CA_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating List
            List<Book> books = new List<Book>();

            //Creating 5 book objects
            Book book1 = new Book("James Joyce", "Ulysses     ", 730, new DateTime(02 / 02 / 1922));
            Book book2 = new Book("B Kieran", "The programming", 279, new DateTime(28 / 02 / 1978));
            Book book3 = new Book("Walter Issac", "Steve Jobs ", 627, new DateTime(24 / 10 / 2011));
            Book book4 = new Book("JRR Tolkien", "The Hobbit  ", 310, new DateTime(21 / 09 / 1937));
            Book book5 = new Book("James Joyce", "Portrait    ", 299, new DateTime(29 / 12 / 1916));

            //Adding objects into list
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);

            //Method used to display the book objects
            Display(books);
            Console.WriteLine("");
            //Sorted then displayed with author
            books.Sort();
            Display(books);



        }//end of main method


        //Method for displaying list
        static void Display(List<Book> books)
        {
            //Displays the books with spaces         
            Console.WriteLine("Author          Title           Pages   Publication Date");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            
        }//end of display

        //Method for display with age
        static void DisplayWithAge(List<Book> books)
        {
            int year = 2019;

            //Displays the books with spaces         
            Console.WriteLine("Author          Title           Pages   Publication Date  Age");
            foreach (Book book in books)
            {
                //int result = DateTime.Parse(book.Published);
                //Console.WriteLine(book + (year - book.Published));
            }

        }//end of display with age
    }
}
