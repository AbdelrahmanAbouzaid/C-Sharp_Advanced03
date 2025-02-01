using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        #region ToString()
        public override string ToString()
        {
            return $"ISBN: {ISBN}\nTitle: {Title}\nAuthors: {DisplayAuthors()}\n" +  // string.Join(" ",Authors)
                $"PublicationDate: {PublicationDate}\nPrice: {Price}";
        }

        public string DisplayAuthors()
        {
            StringBuilder result = new StringBuilder();
            if (Authors != null)
            {
                foreach (var item in Authors)
                    result.Append($"{item}, ");
            }
            return result.ToString();
        }
        #endregion
        //public override string ToString()
        //{
        //    return $"ISBN: {ISBN}\nTitle: {Title}\nAuthors: {string.Join(", ", Authors)}\n" +  
        //        $"PublicationDate: {PublicationDate}\nPrice: {Price}";
        //}

    }
}
