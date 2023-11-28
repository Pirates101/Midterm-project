using System;
using System.IO;
using System.Text.Json;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace TheRealRealMidtermProject
{
	public class SavingBooks
	{
		

		public void WriteBooksToFile(List<string> books)
		{
			var appDirectory = TryCreateAppDiractory();

			var fileDirectory = Path.Combine(appDirectory, @"/Users/David/Desktop/LibraryBooks");
			
			if (File.Exists(fileDirectory))
			{
				File.WriteAllLines(fileDirectory, books);
			}
			else
			{
				File.WriteAllLines(fileDirectory, books);
			}

			

        }
		private string TryGetBookFile()
		{
			var appDirectory = TryCreateAppDiractory();
			return appDirectory;
		}


        public string[] GetCurrentBooks()
        {

            var appDirectory = TryCreateAppDiractory();
            var books = File.ReadAllLines(appDirectory);
            return books;
        }



        public string TryCreateAppDiractory()
		{
			var appDataPath = Environment.SpecialFolder.LocalApplicationData;

			var localAppData = Environment.GetFolderPath(appDataPath);

			var libraryBooks = Path.Combine(localAppData, @"/Users/David/Desktop/LibraryBooks");

			if(Directory.Exists(libraryBooks))
			{
				Directory.CreateDirectory(libraryBooks);

			}
			
			return libraryBooks;
		}
	}
}


	

