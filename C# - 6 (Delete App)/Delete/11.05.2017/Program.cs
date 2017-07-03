using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileManagment_ns;


namespace _11._05._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManagment fm = new FileManagment("C:/Users/Ramil Mamedov/Desktop/SilGetsin");

            fm.getAllFiles();

            Console.WriteLine("Delete Files?");
            Console.WriteLine("1. Yes delete its");
            Console.WriteLine("2. No close app");

            int response = int.Parse(Console.ReadLine());
            if (response == 1)
            {
                fm.deleteAllFiles();
            }
        }
    }
}
