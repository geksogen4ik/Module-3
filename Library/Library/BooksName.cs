using System;

namespace Library
{
    public class BooksName
    {
        public string booksName;
        Books books = new Books();
        public string LibraryPopulating(int choice)
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
                    Console.WriteLine("Enter the Book's Name");
                    booksName = Console.ReadLine();
                    
                    break;

                case 2:
                    Console.WriteLine("You want add Periodical into the Library");
                    Console.WriteLine("Enter the Book's Name");
                    booksName = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("You want add Multivolume Edition into the Library");
                    Console.WriteLine("Enter the Book's Name");
                    booksName = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("You want add Magazine into the Library");
                    Console.WriteLine("Enter the Book's Name");
                    booksName = Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("You want add Monograph into the Library");
                    Console.WriteLine("Enter the Book's Name");
                    booksName = Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("You want add Manuscript into the Library");
                    Console.WriteLine("Enter the Book's Name");
                    booksName = Console.ReadLine();
                    break;

            }
            return booksName;
        }
    }
}