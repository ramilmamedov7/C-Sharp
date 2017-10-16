using System;
using System.Media;
using System.IO;

namespace WoorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "07.10.2017";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            #region SoundPlayer
            //var music = new SoundPlayer();
            //string path = @"C:\Users\Ramil\Desktop\WorkingWithFiles\Slide.wav";
            //music.SoundLocation = path;
            //music.Play();
            //Console.Read();
            #endregion
            //System.Diagnostics.Process.Start(@"C:\Users\Ramil\Desktop\Lab\Paradise.wav");

            #region New Document
            //var document = new StreamWriter(@"C:\Users\Ramil\Desktop\Lab\text.txt");
            //string words;
            //Console.WriteLine("Ürək sözlərinizi daxil edin: ");
            //words = Console.ReadLine();
            //document.WriteLine(words);
            //document.Close();
            #endregion
        }
    }
}
