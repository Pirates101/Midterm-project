using System.Net.Mail;

namespace TheRealRealMidtermProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Library!");
            RunMainMenu();
        }

        static void RunMainMenu()
        {
            FileIO fileIO = new FileIO();
            Library library = new Library();
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
                    int bookSelection = library.GetBookId();
                    library.CheckOutBook(bookSelection);
                    RunMainMenu();
                    break;
                }
                if (userResponse == "2")
                {
                    Console.WriteLine();
                    library.SearchByTitle();
                    int bookSelection = library.GetBookId();
                    library.CheckOutBook(bookSelection);
                    RunMainMenu();
                    break;
                }
                if (userResponse == "3")
                {
                    Console.WriteLine();
                    library.SearchByAuthor();
                    int bookSelection = library.GetBookId();
                    library.CheckOutBook(bookSelection);
                    RunMainMenu();
                    break;
                }
                if (userResponse == "4")
                {
                    Console.Clear();
                    WriteToFile(library);
                    Console.WriteLine($" \n The status of the library can be found in Users/AppData/Library/Library.txt\n Thank you for visiting the library! We hope to see you again soon!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid selection. Please choose from the list below.");
                    continue;
                }
            }
        }

        static void WriteToFile(Library library)
        {
            FileIO fileIO = new FileIO();
            using (StreamWriter file = File.CreateText(fileIO.TryGetBookFile()))
                foreach (Book book in library.LibraryBooks)
                {
                    file.WriteLine($"BookID: {book.BookID}; " +
                        $"Author: {book.Author}; " +
                        $"Title: {book.Title}; " +
                        $"Checked out? {book.CheckedOut}; " +
                        $"Due date: {book.DueDate}\n");
                }
        }
    }
}