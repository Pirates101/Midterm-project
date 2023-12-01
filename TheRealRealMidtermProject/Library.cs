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

            Book book1 = new Book(1, "Stephen King", "The Shining", false);
            Book book2 = new Book(2, "Robert Jordan", "The Eye of the World", false);
            Book book3 = new Book(3, "Stieg Larsson", "The Girl With the Dragon Tattoo", false);
            Book book4 = new Book(4, "Rebecca Yaros", "Fourth Wing", false);
            Book book5 = new Book(5, "Sara Novic", "True Biz", false);
            Book book6 = new Book(6, "Bonnie Garmus", "Lessons in Chemistry", false);
            Book book7 = new Book(7, "Dan Abnett", "Fell Cargo", false);
            Book book8 = new Book(8, "Sarah Penner", "The Lost Apothecary", false);
            Book book9 = new Book(9, "Stacy Willingham", "A Flicker in the Dark", false);
            Book book10 = new Book(10, "Suzanne Collins", "The Ballad of Songbirds and Snakes", false);
            Book book11 = new Book(11, "Gabrielle Zevin", "Tomorrow and Tomorrow and Tomorrow", false);
            Book book12 = new Book(12, "William King", "Dragonslayer", false);

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

            Console.WriteLine("{0, 5} {1, 35} {2, 40} {3, 32} {4, 33}", "Book ID", "Title", "Author", "Status", "Due Date");

            foreach (Book book in LibraryBooks)
            {
                    if (book.CheckedOut == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0, 5} {1, 40} {2, 40} {3, 30} {4, 30}", book.BookID, book.Title, book.Author, "AVAILABLE", "N/A");

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0, 5} {1, 40} {2, 40} {3, 30} {4, 30}", book.BookID, book.Title, book.Author, "CHECKED OUT", book.DueDate );
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
            Console.WriteLine("{0, 5} {1, 35} {2, 40} {3, 32} {4, 33}", "Book ID", "Title", "Author", "Status", "Due Date");
            foreach (Book book in LibraryBooks)
            {
                if (book.Author.Contains(userAuthor, StringComparison.OrdinalIgnoreCase))
                {
                    
                    if (book.CheckedOut == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0, 5} {1, 40} {2, 40} {3, 30} {4, 30}", book.BookID, book.Title, book.Author, "AVAILABLE", "N/A");
                        searchResults.Add(book);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0, 5} {1, 40} {2, 40} {3, 30} {4, 30}", book.BookID, book.Title, book.Author, "AVAILABLE", "N/A");
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }

        public void SearchByTitle()
        {
            List<Book> searchResults = new List<Book>();
            Console.Write("Enter the title you want to search by: ");
            string userTitle = Console.ReadLine().Trim();
            Console.WriteLine();
            Console.WriteLine("{0, 5} {1, 35} {2, 40} {3, 32} {4, 33}", "Book ID", "Title", "Author", "Status", "Due Date");
            foreach (Book book in LibraryBooks)
            {
                if (book.Title.Contains(userTitle, StringComparison.OrdinalIgnoreCase))
                {
                    if (book.CheckedOut == false)
                    {
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine("{0, 5} {1, 40} {2, 40} {3, 30} {4, 30}", book.BookID, book.Title, book.Author, "AVAILABLE", "N/A");
                        searchResults.Add(book);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0, 5} {1, 40} {2, 40} {3, 30} {4, 30}", book.BookID, book.Title, book.Author, "AVAILABLE", "N/A");
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }
        
        public int GetBookId(string message)
        {
            Console.WriteLine();
            Console.Write(message);
            var userInput = Console.ReadLine();
            int.TryParse(userInput, out int bookSelection);
            return bookSelection;
        }

        

    }
}
