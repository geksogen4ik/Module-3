using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Books
    {
        static object locker = new object();
        static object locker1 = new object();

        public static Dictionary<TypeOfBook, BooksName> dictionary = new Dictionary<TypeOfBook, BooksName>();

        BooksName name = new BooksName();
        //public  delegate DateTime BooksDelegate(DateTime todayDate);
        public List<string> booksOnHands = new List<string>();

        public static Dictionary<DateTime, string> expiredBook = new Dictionary<DateTime, string>();

        public enum TypeOfBook
        {
            Book = 1,
            Periodical = 2,
            MultivolumeEdition = 3,
            Magazine = 4,
            Monograph = 5,
            Manuscript = 6
        }

        public BooksName bookName;
        public DateTime term;
        public DateTime todayDate;
        public DateTime returnDate;
        public string someBook;

        public void LibraryPopulating(int choice)
        {
            Int32.TryParse(Console.ReadLine(), out choice);

            dictionary.Add((TypeOfBook)choice, bookName);

            foreach (var books in dictionary)
            {
                Console.WriteLine($"Type of Book - {dictionary.Keys} | Book's Name - {dictionary.Values}");
            }
        }

        public void ExtraditionBooks()
        {
            lock (locker)
            {
                Console.WriteLine("What book do you want to get?");
                someBook = Console.ReadLine();

                if (name.booksnames.Contains(someBook))
                {
                    booksOnHands.Add(someBook);
                    name.booksnames.Remove(someBook);
                }
            }
        }

        public void ReturnBooks()
        {
            lock (locker1)
            {
                Console.WriteLine("What book do you want to return?");
                someBook = Console.ReadLine();

                if (booksOnHands.Contains(someBook))
                {
                    booksOnHands.Remove(someBook);
                    name.booksnames.Add(someBook);
                }
                returnDate = DateTime.Today;
                if(returnDate > term)
                {
                    expiredBook.Add(returnDate, someBook);
                }

            }
        }
    }
}












