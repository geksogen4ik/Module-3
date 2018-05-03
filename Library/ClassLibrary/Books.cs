using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Books 
    {
        public static Dictionary<TypeOfBook, BooksName> dictionary = new Dictionary<TypeOfBook, BooksName>();

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

        public void LibraryPopulating(int choice)
        {
            Console.WriteLine("What type of Book do you want to add into the Library?");
            Console.WriteLine("If you want add 'Book', select - [1]");
            Console.WriteLine("If you want add 'Periodical', select - [2]");
            Console.WriteLine("If you want add 'MultivolumeEdition', select - [3]");
            Console.WriteLine("If you want add 'Magazine', select - [4]");
            Console.WriteLine("If you want add 'Monograph', select - [5]");
            Console.WriteLine("If you want add 'Manuscript', select - [6]");

            Int32.TryParse(Console.ReadLine(), out choice);

            dictionary.Add((TypeOfBook)choice, bookName);

            foreach (var books in dictionary)
            {
                Console.WriteLine($"Type of Book - {dictionary.Keys} | Book's Name - {dictionary.Values}");
            }
        }
    }
}

        

            
      

    
