using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRealRealMidtermProject
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public bool CheckedOut { get; set; }
        public string DueDate { get; set; }

        public Book(string author, string title, bool checkedOut, string dueDate)
        {
            Author = author;
            Title = title;
            CheckedOut = checkedOut;
            DueDate = dueDate;
        }







        //public string SearchByTitle()
        //{
        //    // Like SearchByAuthor(), but using title as the search param
        //}

        

    }
}
