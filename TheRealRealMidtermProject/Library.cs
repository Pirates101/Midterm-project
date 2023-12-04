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
            Book book13 = new Book(13, "James McBride", "The Heaven & Earth Grocer Store", false);
            Book book14 = new Book(14, "Amanda Peters", "The Berry Pickers: A Novel", false);
            Book book15 = new Book(15, "Jonathan Eig", "King: A Life", false);
            Book book16 = new Book(16, "Nathan Hill", "Wellness: A Novel", false);
            Book book17 = new Book(17, "Abraham Verghese", "The Covenant of Water", false);
            Book book18 = new Book(18, "Stephen King", "Holly", false);
            Book book19 = new Book(19, "Walter Isaacson", "Elon Musk", false);
            Book book20 = new Book(20, "Dennis Lehane", "Small Mercies: A Detective Mystery", false);
            Book book21 = new Book(21, "Ann Napolitano", "Hello Beautiful", false);
            Book book22 = new Book(22, "David Grann", "The Wager", false);
            Book book23 = new Book(23, "Jesmyn Ward", "Let Us Descend", false);
            Book book24 = new Book(24, "Deepti Kapoor", "Age of Vice", false);
            Book book25 = new Book(25, "Naomi Alderman", "The Future", false);
            Book book26 = new Book(26, "Jessica Knoll", "A Bright Young Woman", false);
            Book book27 = new Book(27, "Helen Elaine Lee", "Pomegranate: A Novel", false);
            Book book28 = new Book(28, "Nita Prose", "The Mystery Guest", false);
            Book book29 = new Book(29, "Scott Shane", "Flee North: A Forgotten Hero", false);
            Book book30 = new Book(30, "S.A. Cosby", "All the Sinners Bleed: A Novel", false);
            Book book31 = new Book(31, "Lucy Score", "Things We Left Behind", false);
            Book book32 = new Book(32, "Ann Patchett", "Tom Lake", false);
            Book book33 = new Book(33, "Angie Kim", "Happiness Falls (Good Morning America)", false);
            Book book34 = new Book(34, "Lisa See", "Lady Tan's Circle of Women", false);
            Book book35 = new Book(35, "Emilia Hart", "Weyward: A Novel", false);
            Book book36 = new Book(36, "Daniel Mason", "North Woods: A Novel", false);
            Book book37 = new Book(37, "Peter Attia", "Outlive: The Science and Art of Longevity", false);
            Book book38 = new Book(38, "Brendan Slocumb", "Symphony of Secrets: A Novel", false);
            Book book39 = new Book(39, "Colson Whitehead", "Crook Manifesto: A Novel", false);
            Book book40 = new Book(40, "Rachel Heng", "The Great Reclamation: A Novel", false);
            Book book41 = new Book(41, "Emily Henry", "Happy Place", false);
            Book book42 = new Book(42, "Matthew Desmond", "Poverty, by America", false);
            Book book43 = new Book(43, "Leigh Bardugo", "Hell Bent: A Novel", false);
            Book book44 = new Book(44, "Angeline Boulley", "Warrior Girl Unearthed", false);
            Book book45 = new Book(45, "R.F. Kuang", "Yellowface", false) ;
            Book book46 = new Book(46, "Richard Osman", "The Last Devil to Die", false);
            Book book47 = new Book(47, "Azman Ahmed", "Fear Is Just A Word", false);
            Book book48 = new Book(48, "William Kent Krueger", "The River We Remember: A Novel", false);
            Book book49 = new Book(49, "Eleanor Catton", "Birnam Wood: A Novel", false);
            Book book50 = new Book(50, "Donovan X. Ramsey", "When Crack Was King", false);
            Book book51 = new Book(51, "Jeannette Walls", "Hang the Moon", false);
            Book book52 = new Book(52, "Bryan Washington", "Family Meal: A Novel", false);
            Book book53 = new Book(53, "Sy Montgomery", "Of Time and Turtles", false);
            Book book54 = new Book(54, "R. Eric Thomas", "Congratulations, The Best Is Over", false);
            Book book55 = new Book(55, "Rebecca Yarros", "Iron Flame", false);
            Book book56 = new Book(56, "Mary Beard", "Emperor of Rome", false);
            Book book57 = new Book(57, "Karl Geary", "Juno Loves Legs: A Novel", false);
            Book book58 = new Book(58, "Rebecca Renner", "Gator Country", false);
            Book book59 = new Book(59, "Esau McCaulley", "How Far To the Promised Land", false);
            Book book60 = new Book(60, "John Scalzi", "Starter Villain", false);
            Book book61 = new Book(61, "Max Marshall", "Among the Bros", false);
            Book book62 = new Book(62, "Nina Simon", "Mother-Daughter Murder Night", false);
            Book book63 = new Book(63, "Noelle Crooks", "Under the Influence", false);
            Book book64 = new Book(64, "Dwight Garner", "The Upstairs Delicatessen", false);
            Book book65 = new Book(65, "Stephanie Land", "Class: A Memoir", false);
            Book book66 = new Book(66, "Amy Chua", "The Golden Gate", false);
            Book book67 = new Book(67, "Luis Alberto Urrea", "Good Night, Irene", false);
            Book book68 = new Book(68, "Paul Murray", "The Bee Sting", false);
            Book book69 = new Book(69, "Charlene Carr", "Hold My Girl", false);
            Book book70 = new Book(70, "Claire Keegan", "So Late in the Day", false);
            Book book71 = new Book(71, "Martin Baron", "Collision of Power", false);
            Book book72 = new Book(72, "Alix E. Harrow", "Starling House", false) ;
            Book book73 = new Book(73, "Tania James", "Loot: A Novel", false);
            Book book74 = new Book(74, "Tracy K Smith", "To Free the Captives", false);
            Book book75 = new Book(75, "Lauren Asher", "Love Redesigned", false);
            Book book76 = new Book(76, "Ed Park", "Same Bed Different Dreams", false);
            Book book77 = new Book(77, "Ashley Poston", "The Seven Year Sip", false);
            Book book78 = new Book(78, "Susan Meissner", "Only the Beautiful", false);
            Book book79 = new Book(79, "Andre Dubus III", "Such a Kindness", false);
            Book book80 = new Book(80, "Rick Rubin", "The Creative Act: A Way of Being", false);
            Book book81 = new Book(81, "Lauren Groff", "The Vaster Wilds: A Novel", false);
            Book book82 = new Book(82, "Michael Harriot", "Black AF History", false);
            Book book83 = new Book(83, "Karin Lin-Greenburg", "You Are Here", false);
            Book book84 = new Book(84, "Rich Paul", "Lucky Me: A Memoir", false);
            Book book85 = new Book(85, "Meg Kissinger", "While You Were Out", false);
            Book book86 = new Book(86, "Etaf Rum", "Evil Eye", false);
            Book book87 = new Book(87, "Cat Bohannon", "Eve", false);
            Book book88 = new Book(88, "V.E.Schwab", "The Fragile Threads", false);
            Book book89 = new Book(89, "Hector Tobar", "Our Migrant Souls", false);
            Book book90 = new Book(90, "Katherine Center", "Hello Stranger", false);
            Book book91 = new Book(91, "Maggie Smith", "You Could Make This Place Beautiful", false);
            Book book92 = new Book(92, "Elin Hilderbrand", "The Five Star Weekend", false);
            Book book93 = new Book(93, "Vanessa Lilie", "Blood Sisters", false);
            Book book94 = new Book(94, "Nana Kwame", "Chain Gang All Stars", false);
            Book book95 = new Book(95, "Ali Hazelwood", "Love, Theoretically", false) ;
            Book book96 = new Book(96, "Alice McDermott", "Aboslution: A Novel", false);
            Book book97 = new Book(97, "Adam Grant", "Hidden Potential", false);
            Book book98 = new Book(98, "Tess Gerritsen", "The Spy Coast", false);
            Book book99 = new Book(99, "Loren Grush", "The Six", false);
            Book book100 = new Book(100, "Chuck Tingle", "Camp Damascus", false);


                

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
            LibraryBooks.Add(book13);
            LibraryBooks.Add(book14);
            LibraryBooks.Add(book15);
            LibraryBooks.Add(book16);
            LibraryBooks.Add(book17);
            LibraryBooks.Add(book18);
            LibraryBooks.Add(book19);
            LibraryBooks.Add(book20);
            LibraryBooks.Add(book21);
            LibraryBooks.Add(book22);
            LibraryBooks.Add(book23);
            LibraryBooks.Add(book24);
            LibraryBooks.Add(book25);
            LibraryBooks.Add(book26);
            LibraryBooks.Add(book27);
            LibraryBooks.Add(book28);
            LibraryBooks.Add(book29);
            LibraryBooks.Add(book30);
            LibraryBooks.Add(book31);
            LibraryBooks.Add(book32);
            LibraryBooks.Add(book33);
            LibraryBooks.Add(book34);
            LibraryBooks.Add(book35);
            LibraryBooks.Add(book36);
            LibraryBooks.Add(book37);
            LibraryBooks.Add(book38);
            LibraryBooks.Add(book39);
            LibraryBooks.Add(book40);
            LibraryBooks.Add(book41);
            LibraryBooks.Add(book42);
            LibraryBooks.Add(book43);
            LibraryBooks.Add(book44);
            LibraryBooks.Add(book45);
            LibraryBooks.Add(book46);
            LibraryBooks.Add(book47);
            LibraryBooks.Add(book48);
            LibraryBooks.Add(book49);
            LibraryBooks.Add(book50);
            LibraryBooks.Add(book51);
            LibraryBooks.Add(book52);
            LibraryBooks.Add(book53);
            LibraryBooks.Add(book54);
            LibraryBooks.Add(book55);
            LibraryBooks.Add(book56);
            LibraryBooks.Add(book57);
            LibraryBooks.Add(book58);
            LibraryBooks.Add(book59);
            LibraryBooks.Add(book60);
            LibraryBooks.Add(book61);
            LibraryBooks.Add(book62);
            LibraryBooks.Add(book63);
            LibraryBooks.Add(book64);
            LibraryBooks.Add(book65);
            LibraryBooks.Add(book66);
            LibraryBooks.Add(book67);
            LibraryBooks.Add(book68);
            LibraryBooks.Add(book69);
            LibraryBooks.Add(book70);
            LibraryBooks.Add(book71);
            LibraryBooks.Add(book72);
            LibraryBooks.Add(book73);
            LibraryBooks.Add(book74);
            LibraryBooks.Add(book75);
            LibraryBooks.Add(book76);
            LibraryBooks.Add(book77);
            LibraryBooks.Add(book78);
            LibraryBooks.Add(book79);
            LibraryBooks.Add(book80);
            LibraryBooks.Add(book81);
            LibraryBooks.Add(book82);
            LibraryBooks.Add(book83);
            LibraryBooks.Add(book84);
            LibraryBooks.Add(book85);
            LibraryBooks.Add(book86);
            LibraryBooks.Add(book87);
            LibraryBooks.Add(book88);
            LibraryBooks.Add(book89);
            LibraryBooks.Add(book90);
            LibraryBooks.Add(book91);
            LibraryBooks.Add(book92);
            LibraryBooks.Add(book93);
            LibraryBooks.Add(book94);
            LibraryBooks.Add(book95);
            LibraryBooks.Add(book96);
            LibraryBooks.Add(book97);
            LibraryBooks.Add(book98);
            LibraryBooks.Add(book99);
            LibraryBooks.Add(book100);
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
