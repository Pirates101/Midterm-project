﻿using System.Net.Mail;

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
                Console.WriteLine($"==MAIN MENU==\n\nWhat would you like to do? \n1. View a list of all books in the library \n2. Search for a book by title \n3. Search for a book by author\n4. Return a book\n5. Leave the library");
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
                    file.WriteLine($"BookID: {book.BookID}; " +
                        $"Author: {book.Author}; " +
                        $"Title: {book.Title}; " +
                        $"Checked out? {book.CheckedOut}; " +
                        $"Due date: {book.DueDate}\n");
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
                }
            }
        }

    }
}