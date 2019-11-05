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

namespace CA_OOP
{
     //Enum used to create Genre with values
        public enum Genre
        {
            Fiction,
            Biography,
            Computing,
            Literature,
        }
    class Book : IComparable
    {
       

        //Book properties
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public int Pages { get; set; }
        public Genre GetGenre { get; }

        //Construtors
        public Book(string title, string author, int pages, DateTime published)
        {
            Title = title;
            Author = author;
            Published = published;
            Pages = pages;
        }

        //ToString to display values
        public override string ToString()
        {
            return $"{Title}\t{Author}\t{Pages}\t{Published}\t{GetGenre}";
        }

        //Used to sort with author first
        public int CompareTo(object obj)
        {
            Book that = (Book)obj;
            return this.Title.CompareTo(that.Title);           
        }

        //Used to sort with title first
        public int CompareTo1(object obj)
        {
            Book that = (Book)obj;
            return this.Author.CompareTo(that.Author);
        }
    }
}
