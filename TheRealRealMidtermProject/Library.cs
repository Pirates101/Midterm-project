using System;
using System.Collections.Generic;
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
            // Menu system from Frank
            // Refine search by title

            LibraryBooks = new List<Book>();

            Book book1 = new Book("Stephen King", "The Shining", false, null);
            Book book2 = new Book("Robert Jordan", "The Eye of the World", false, null);
            Book book3 = new Book("Stieg Larsson", "The Girl With the Dragon Tattoo", false, null);
            Book book4 = new Book("Rebecca Yaros", "Fourth Wing", false, null);
            Book book5 = new Book("Sara Novic", "True Biz", false, null);
            Book book6 = new Book("Bonnie Garmus", "Lessons in Chemistry", false, null);
            Book book7 = new Book("Dan Abnett", "Fell Cargo", false, null);
            Book book8 = new Book("Sarah Penner", "The Lost Apothecary", false, null);
            Book book9 = new Book("Stacy Willingham", "A Flicker in the Dark", false, null);
            Book book10 = new Book("Suzanne Collins", "The Ballad of Songbirds and Snakes", false, null);
            Book book11 = new Book("Gabrielle Zevin", "Tomorrow and Tomorrow and Tomorrow", false, null);
            Book book12 = new Book("William King", "Dragonslayer", false, null);

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

            // Formatting from Aimee YAY 
        }

        public void DisplayBooks()
        {
            foreach (Book book in LibraryBooks)
            {
                Console.WriteLine($"{book.Title}, {book.Author}");
            }
        }

        public void SearchByAuthor()
        {
            Console.WriteLine("Enter the author you want to search by ");
            string userAuthor = Console.ReadLine().Trim();
            foreach (Book book in LibraryBooks)
            {
                if (book.Author.Contains(userAuthor, StringComparison.OrdinalIgnoreCase))
                {
                    if (book.CheckedOut == false)
                    {
                        Console.WriteLine($"{book.Title} is available");
                    }
                    else
                    {
                        Console.WriteLine($"{book.Title} is checked out");
                    }
                }
            }
        }

        public void SearchByTitle()
        {
            Console.Write("Enter the title you want to search by: ");
            string userTitle = Console.ReadLine().Trim();
            foreach (Book book in LibraryBooks)
            {
                if (book.Title.Contains(userTitle, StringComparison.OrdinalIgnoreCase))
                {
                    if (book.CheckedOut == false)
                    {
                        Console.WriteLine($"{book.Title} by {book.Author} is available.");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, {book.Title} by {book.Author} is checked out");
                    }
                }
            }
        }

        public void CheckOutBook(Book book)
        {
            




            // Ben will work on this

        }

        // File IO work David

    }
}
