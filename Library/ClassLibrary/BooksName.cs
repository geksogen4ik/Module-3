using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BooksName
    {

        public string bookName;
        public List<string> booksnames = new List<string>();
        public string NameOfBook()
        {
            Console.WriteLine("Enter the Book's Name");
            bookName = Console.ReadLine();
            booksnames.Add(bookName);
            return bookName;
        }

    }
}
