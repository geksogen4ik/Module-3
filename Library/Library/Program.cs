using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new Books();
            var limitation = new Limitation();
           
            books.LibraryPopulating();

            limitation.DateTerm();

        }
    }
}
