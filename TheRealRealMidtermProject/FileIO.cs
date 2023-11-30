using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRealRealMidtermProject
{
    public class FileIO
    {
        public string TryGetBookFile()
        {
            var appDirectory = TryCreateAppDirectory();

            var fileDirectory = Path.Combine(appDirectory, "Library.txt");

            return fileDirectory;
        }
        private string TryCreateAppDirectory()
        {
            var appDataPath = Environment.SpecialFolder.LocalApplicationData;

            string localAppDataPath = Environment.GetFolderPath(appDataPath);

            string studentAppPath = Path.Combine(localAppDataPath, "Library");


            if (!Directory.Exists(studentAppPath)) 
            {
                Directory.CreateDirectory(studentAppPath);
            }

            return studentAppPath;
        }
    }
}
