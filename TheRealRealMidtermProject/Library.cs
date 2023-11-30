using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRealRealMidtermProject
{
    public class Library
    {
        public List<Book> LibraryBooks;

        public Library()
        {
            LibraryBooks = new List<Book>();

            Book book1 = new Book(1, "Stephen King", "The Shining", false, "N/A");
            Book book2 = new Book(2, "Robert Jordan", "The Eye of the World", true, "January 1st, 2024");
            Book book3 = new Book(3, "Stieg Larsson", "The Girl With the Dragon Tattoo", false, "N/A");
            Book book4 = new Book(4, "Rebecca Yaros", "Fourth Wing", false, "N/A");
            Book book5 = new Book(5, "Sara Novic", "True Biz", false, "N/A");
            Book book6 = new Book(6, "Bonnie Garmus", "Lessons in Chemistry", false, "N/A");
            Book book7 = new Book(7, "Dan Abnett", "Fell Cargo", false, "N/A");
            Book book8 = new Book(8, "Sarah Penner", "The Lost Apothecary", false, "N/A");
            Book book9 = new Book(9, "Stacy Willingham", "A Flicker in the Dark", true, "January 1st, 2024");
            Book book10 = new Book(10, "Suzanne Collins", "The Ballad of Songbirds and Snakes", false, "N/A");
            Book book11 = new Book(11, "Gabrielle Zevin", "Tomorrow and Tomorrow and Tomorrow", false, "N/A");
            Book book12 = new Book(12, "William King", "Dragonslayer", false, "N/A");

            LibraryBooks.Add(book1);
            LibraryBooks.Add(book2);
            LibraryBooks.Add(book3);
            LibraryBooks.Add(book4);
            LibraryBooks.Add(book5);
            LibraryBooks.Add(book6);
            LibraryBooks.Add(book7);
            LibraryBooks.Add(book8);
            LibraryBooks.Add(book9);
            LibraryBooks.Add(book10);
            LibraryBooks.Add(book11);
            LibraryBooks.Add(book12);
        }

        public void DisplayBooks()
        {

            Console.WriteLine("{0, 5} {1, 38} {2, 48} {3, 59}", "Book ID", "Title", "Author", "Status");

            foreach (Book book in LibraryBooks)
            {
                    if (book.CheckedOut == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0, 5} {1, 40} {2, 50} {3, 60}", book.BookID, book.Title, book.Author, "AVAILABLE");

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0, 5} {1, 40} {2, 50} {3, 60}", book.BookID, book.Title, book.Author, "CHECKED OUT");
                    }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void SearchByAuthor()
        {
            List<Book> searchResults = new List<Book>();
            Console.Write("Enter the author you want to search by: ");
            string userAuthor = Console.ReadLine().Trim();
            Console.WriteLine();
            int idx = 1;
            foreach (Book book in LibraryBooks)
            {
                if (book.Author.Contains(userAuthor, StringComparison.OrdinalIgnoreCase))
                {
                    if (book.CheckedOut == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{idx}. (Book ID: {book.BookID}) {book.Title} by {book.Author} - Status: AVAILABLE");
                        searchResults.Add(book);
                        idx++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{idx}. (Book ID: {book.BookID}) {book.Title} by {book.Author} - Status: CHECKEDOUT");
                        idx++;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.Write($"If you would like to check out one of these books, enter the Book ID here or enter 0 to go back to the main menu: ");
            var userInput = Console.ReadLine();
            int.TryParse(userInput, out int bookSelection);
        }

        public void SearchByTitle()
        {
            List<Book> searchResults = new List<Book>();
            Console.Write("Enter the title you want to search by: ");
            string userTitle = Console.ReadLine().Trim();
            Console.WriteLine();
            int idx = 1;
            foreach (Book book in LibraryBooks)
            {
                if (book.Title.Contains(userTitle, StringComparison.OrdinalIgnoreCase))
                {
                    if (book.CheckedOut == false)
                    {
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine($"{idx}. (Book ID: {book.BookID}) {book.Title} by {book.Author} - Status: AVAILABLE");
                        searchResults.Add(book);
                        idx++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{idx}. (Book ID: {book.BookID}) {book.Title} by {book.Author} - Status: CHECKEDOUT");
                        idx++;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            int bookSelection = GetBookId();
            CheckOutBook(bookSelection);
        }
        
        public int GetBookId()
        {
            Console.WriteLine();
            Console.Write($"If you would like to check out one of these books, enter the Book ID here or enter 0 to go back to the main menu: ");
            var userInput = Console.ReadLine();
            int.TryParse(userInput, out int bookSelection);
            return bookSelection;
        }

        public void CheckOutBook(int bookSelection)
        {
            foreach (Book book in LibraryBooks)
            {
                if (bookSelection == book.BookID)
                {
                    book.CheckedOut = true;
                }
            }

        }
        public void CheckInBook(Book book)
        {
            book.CheckedOut = false;

        }

    }
}
