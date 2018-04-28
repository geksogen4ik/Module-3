using System;

namespace Library
{
    public  class BooksName
    {
        public string bookName;
        public string NameOfBook()
        {
            Console.WriteLine("Enter the Book's Name");
            bookName = Console.ReadLine();
            return bookName;
        }

    }
}