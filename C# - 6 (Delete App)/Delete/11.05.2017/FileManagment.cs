using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManagment_ns
{

    class FileManagment
    {
        private string dir;
        private string[] allFiles;
        private string[] foundedFiles = new String [80];
        public string[] single;

        public FileManagment(string dir)
        {
            this.dir = dir;
        }

        public string[] AllFiles{
            get
            {
                return this.allFiles;
            }
        }

        public void getAllFiles()
        {
            this.allFiles = Directory.GetFiles(this.dir,"*.*",SearchOption.AllDirectories);
            int count = 0;
            foreach (string file in this.AllFiles)
            {
                FileInfo info = new FileInfo(file);
                DateTime now = DateTime.Now;
                DateTime file_date = new DateTime(info.LastAccessTime.Year, info.LastAccessTime.Month, info.LastAccessTime.Day, info.LastAccessTime.Hour, info.LastAccessTime.Minute, info.LastAccessTime.Second);

                double diff = now.Subtract(file_date).TotalDays;
                if (diff > -1)
                {
                    foundedFiles[count] = info.FullName.ToString();
                    count++;
                    Console.WriteLine(diff.ToString() + " " + info.FullName.ToString());
                }
                
            }
        }

        public void deleteAllFiles()
        {
            foreach(string single in this.foundedFiles)
            {
                File.Delete(single);
            }
        }
    }
}
