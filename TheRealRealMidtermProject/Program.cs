namespace TheRealRealMidtermProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Library!");
            RunMainMenu();
        }

        static void RunMainMenu()
        {
            Library library = new Library();
           
            library.DisplayBooks();

            //library.SearchByAuthor();
            Console.WriteLine();

            library.SearchByTitle();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"What would you like to do? \n1. View a list of all books in the library \n2. Search for a book by title \n3. Search for a book by author\n4. Leave the library");
                Console.Write("Selection: ");
                string userResponse = Console.ReadLine();
                if (userResponse == "1")
                {
                    Console.WriteLine();
                    library.DisplayBooks();
                    break;
                }
                if (userResponse == "2")
                {
                    Console.WriteLine();
                    library.SearchByTitle();
                    break;
                }
                if (userResponse == "3")
                {
                    Console.WriteLine();
                    library.SearchByAuthor();
                    break;
                }
                if (userResponse == "4")
                {
                    Console.Clear();
                    Console.WriteLine($"\n Thank you for visiting the library! We hope to see you again soon!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid selection. Please choose from the list below.");
                    continue;
                }
            }
        }
    }
}