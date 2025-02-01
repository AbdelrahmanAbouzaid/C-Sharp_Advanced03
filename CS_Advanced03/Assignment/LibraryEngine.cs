using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    delegate string BookFuncDelgate(Book book);
    internal class LibraryEngine
    {
        //User-Define Delegate
        //public static void ProcessBooks(List<Book> blist, BookFuncDelgate fPtr)
        //{
        //    if (blist?.Count > 0)
        //    {
        //        foreach (var b in blist)
        //        {
        //            Console.WriteLine(fPtr(b));
        //        }
        //    }
        //}

        //Built-in Delegate
        public static void ProcessBooks(List<Book> blist, Func<Book,string> fPtr)
        {
            if (blist?.Count > 0)
            {
                foreach (var b in blist)
                {
                    Console.WriteLine(fPtr(b));
                }
            }
        }
    }
}
