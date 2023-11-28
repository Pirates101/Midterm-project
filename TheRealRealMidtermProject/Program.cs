namespace TheRealRealMidtermProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Console.WriteLine("Welcome to the Poutine Tots Libary. \nSee below for a list of our books. You can also search by title or author to check availability.");
            Console.WriteLine();

            library.DisplayBooks();

            //library.SearchByAuthor();
            Console.WriteLine();

            library.SearchByTitle();
        }
    }
}