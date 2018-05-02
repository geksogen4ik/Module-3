using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Library
{
    class Program

    {
       
        static void Main(string[] args)
        {

           
             var books = new Books();
            var limitation = new Limitation();

            Console.WriteLine("What type of Book do you want to add into the Library?");
            Console.WriteLine("If you want add 'Book', select - [1]");
            Console.WriteLine("If you want add 'Periodical', select - [2]");
            Console.WriteLine("If you want add 'MultivolumeEdition', select - [3]");
            Console.WriteLine("If you want add 'Magazine', select - [4]");
            Console.WriteLine("If you want add 'Monograph', select - [5]");
            Console.WriteLine("If you want add 'Manuscript', select - [6]");

            int choice = 0;
            Int32.TryParse(Console.ReadLine(), out choice);

            books.LibraryPopulating();

            limitation.DateTerm();

        }
    }
}
