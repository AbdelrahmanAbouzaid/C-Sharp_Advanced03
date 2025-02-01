namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book book = new Book("1234", "ReadDead", new string[] { "Abdelrahman", "Omar" }, new DateTime().Date, 299);
            //Console.WriteLine(book);


            List<Book> books = new List<Book>()
            {
                new Book("1234", "Taming Flame", new string[] { "Abdelrahman", "Omar" }, new DateTime().Date, 299),
                new Book("3456", "A Story of Yesterday", new string[] { "Toqa", "Khadija" }, new DateTime().Date, 299),
                new Book("3453", "Fahrenheit 451", new string[] { "Ahmed", "Ali" }, new DateTime().Date, 299),
                new Book("9865", "The Elephant Tree", new string[] { "Sayed", "Osama" }, new DateTime().Date, 299),
            };

            //User-Define Delegate
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);


            //Anonymous Method
            Func<Book, string> func = delegate (Book book) { return book.ISBN; };
            LibraryEngine.ProcessBooks(books, func);

            //Lamda Expression
            LibraryEngine.ProcessBooks(books, x => x.PublicationDate.ToString());

        }
    }
}
