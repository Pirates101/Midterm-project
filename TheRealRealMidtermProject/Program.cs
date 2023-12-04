using System.Net.Mail;


using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

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
                Console.WriteLine($"==MAIN MENU==\n\nWhat would you like to do? \n\n1. View a list of all books in the library \n2. Search for a book by title \n3. Search for a book by author\n4. Return a book\n5. Leave the library");
                Console.Write("\nSelection: ");
                string userResponse = Console.ReadLine();
                if (userResponse == "1")
                {
                    Console.WriteLine();
                    library.DisplayBooks();
                    CheckoutBook(library);
                    Console.Clear();
                }

                else if (userResponse == "2")
                {
                    Console.WriteLine();
                    library.SearchByTitle();
                    CheckoutBook(library);
                    Console.Clear();
                }

                else if (userResponse == "3")
                {
                    Console.WriteLine();
                    library.SearchByAuthor();
                    CheckoutBook(library);
                    Console.Clear();
                }

                else if (userResponse == "4")
                {
                    Console.WriteLine();
                    library.DisplayBooks();
                    CheckInBook(library);
                    Console.Clear();
                }

                else if (userResponse == "5")
                {
                    Console.Clear();
                    WriteToFile(library);
                    Console.WriteLine($" \n The status of the library can be found in Users/AppData/Library/Library.txt\n Thank you for visiting the library! We hope to see you again soon!");
                    break;
                }

                else if (userResponse == "6")
                {
                    Console.Clear();
                    
                    BurnItDown();
                    Console.WriteLine("The library is on fire AHHHHHHHHHHHHHH");
                    break;
                }

                else
                {
                    Console.WriteLine($"Invalid selection. Please choose from the list below.");
                }
            }
        }

        static void WriteToFile(Library library)
        {
            FileIO fileIO = new FileIO();
            using (StreamWriter file = File.CreateText(fileIO.TryGetBookFile()))
                foreach (Book book in library.LibraryBooks)
                {
                    if (book.CheckedOut == true)
                    {
                        file.WriteLine($"BookID: {book.BookID}; " + $"Author: {book.Author}; " + $"Title: {book.Title}; " + $"Checked out? {book.CheckedOut}; " + $"Due date: {book.DueDate}\n");
                    }
                    else if (book.CheckedOut == false)
                    {
                        file.WriteLine($"BookID: {book.BookID}; " + $"Author: {book.Author}; " + $"Title: {book.Title}; " + $"Checked out? {book.CheckedOut}; " + $"Due date: N/A\n");
                    }
                }
        }

        static void CheckoutBook(Library library)
        {
            int bookSelection = library.GetBookId("Enter the book ID of the book you would like to check out, or enter 0 to return to the Main Menu: ");

                foreach (Book book in library.LibraryBooks)
                {
                    if (book.BookID == bookSelection)
                    {
                        book.CheckedOut = true;
                        book.DueDate = DateTime.UtcNow.AddDays(14);
                        Console.Write($"\n{book.Title} has been successfully ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("CHECKED OUT");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" and is due back on ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{book.DueDate}");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(".");

                    PressAnyKeyToContinue();
                }
                    if (bookSelection == 0) 
                    {
                        break;
                    }
                }
        }

        static void CheckInBook(Library library)
        {
            int bookSelection = library.GetBookId("Enter the book ID of the book you would like to return, or enter 0 to return to the Main Menu: ");

            foreach (Book book in library.LibraryBooks)
            {
                if (book.BookID == bookSelection)
                {
                    book.CheckedOut = false;
                    Console.Write($"\n{book.Title} has been successfully ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("CHECKED IN");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(". Thank you!");
                    PressAnyKeyToContinue();
                }
            }
        }

        static void PressAnyKeyToContinue()
        {
            Console.Write("\nPress any key to return to the Main Menu.");
            Console.ReadKey();
            Console.Clear();
        }

        static void BurnItDown()
        {
            string imagePath = @"C:\Users\manbe\dev\TheRealRealMidtermProject\Fire2.jpg";

            using var inputStream = new FileStream(
                imagePath,
                FileMode.Open, 
                FileAccess.Read,
                FileShare.Read);

            var generator = new Generator();

            using var sourceImage = Image.Load(inputStream);

            using var imageRgba32 = sourceImage.CloneAs<Rgba32>();

            using var image = new ImageSharpImageSource(imageRgba32);

            var asciiArt = generator.GenerateAsciiArtFromImage(image);

            Console.WriteLine(asciiArt.Art);
        }

    }
}