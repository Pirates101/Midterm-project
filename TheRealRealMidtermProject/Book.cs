using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRealRealMidtermProject
{
    public class Book
    {
        public int BookID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public bool CheckedOut { get; set; }
        public DateTime DueDate { get; set; }

        public Book(int id, string author, string title, bool checkedOut)
        {
            BookID = id;
            Author = author;
            Title = title;
            CheckedOut = checkedOut;
            DueDate = DateTime.Today;
        }
    }
}
