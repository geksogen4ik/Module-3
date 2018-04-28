using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Books 
    {
        public Dictionary<TypeOfBook, BooksName> dictionary = new Dictionary<TypeOfBook, BooksName>();

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

        public void LibraryPopulating(int choice)
        {
            
            Console.WriteLine("What type of Book do you want to add into the Library?");
            Console.WriteLine("If you want add 'Book', select - [1]");
            Console.WriteLine("If you want add 'Periodical', select - [1]");
            Console.WriteLine("If you want add 'MultivolumeEdition', select - [3]");
            Console.WriteLine("If you want add 'Magazine', select - [4]");
            Console.WriteLine("If you want add 'Monograph', select - [5]");
            Console.WriteLine("If you want add 'Manuscript', select - [6]");

            Int32.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You want add Book into the Library");
                    dictionary.Add(TypeOfBook.Book, bookName);
                    break;

                case 2:
                    Console.WriteLine("You want add Periodical into the Library");
                    dictionary.Add(TypeOfBook.Periodical, bookName);
                    break;
                case 3:
                    Console.WriteLine("You want add Multivolume Edition into the Library");
                    dictionary.Add(TypeOfBook.MultivolumeEdition, bookName);
                    break;
                case 4:
                    Console.WriteLine("You want add Magazine into the Library");
                    dictionary.Add(TypeOfBook.Magazine, bookName);
                    break;
                case 5:
                    Console.WriteLine("You want add Monograph into the Library");
                    dictionary.Add(TypeOfBook.Monograph, bookName);
                    break;
                case 6:
                    Console.WriteLine("You want add Manuscript into the Library");
                    dictionary.Add(TypeOfBook.Manuscript, bookName);
                    break;
            }
            
        }
    }
}
