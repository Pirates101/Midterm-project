namespace TheRealRealMidtermProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // I'm going to put the menu system right here.

            library.DisplayBooks();

            //library.SearchByAuthor();
            library.SearchByTitle();
        }
    }
}