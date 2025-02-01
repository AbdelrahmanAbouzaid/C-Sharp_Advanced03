using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book.Title;
        }

        public static string GetAuthors(Book book)
        {
            //StringBuilder result = new StringBuilder();
            //if (book.Authors != null)
            //{
            //    foreach (var item in book.Authors)
            //        result.Append($"{item}, ");
            //}
            //return result.ToString();

            return book.DisplayAuthors();
        }

        public static string GetPrice(Book book)
        {
            return book.Price.ToString();
        }
    }
}
