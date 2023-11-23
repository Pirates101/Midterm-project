namespace TheRealRealMidtermProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.DisplayBooks();

            //library.SearchByAuthor();
            library.SearchByTitle();
        }
    }
}