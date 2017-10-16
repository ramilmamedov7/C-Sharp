using System;
using System.Text;

namespace Restoran
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Restoran";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Restoranımıza xoş gəlmisiniz!\n");
            Console.ForegroundColor = ConsoleColor.White;
            int choice, piece;
            double total, sum = 0;
            Console.WriteLine("Menu:" + "\nYeməklər " + new string('-', 31) + " İçkilər");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1.Salat. - [1.5AZN] " + new string('-', 20) + " 5.Su.    - [0.5AZN]");
            Console.WriteLine("2.Kabab. - [3.5AZN] " + new string('-', 20) + " 6.Ayran. - [0.7AZN]");
            Console.WriteLine("3.Şorba. - [1.7AZN] " + new string('-', 20) + " 7.Kola.  - [1.0AZN]");
            Console.WriteLine("4.Dönər. - [1.2AZN] " + new string('-', 20) + " 8.Çay.   - [0.5AZN]");
            ////Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("0.Programı bağla.");
            for (int i = 1; i < 100; i++)
            {
                Console.Write("\n>>Seçəcəyiniz məhsulun nömrəsini qeyd edin: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Neçə pors salat istəyirsiniz?");
                    piece = Convert.ToInt32(Console.ReadLine());
                    total = piece * 1.5;
                    sum = sum + total;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Neçə porst kabab istəyirsiniz?");
                    piece = Convert.ToInt32(Console.ReadLine());
                    total = piece * 3.5;
                    sum = sum + total;
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Neçə pors sup istəyirsiniz?");
                    piece = Convert.ToInt32(Console.ReadLine());
                    total = piece * 1.7;
                    sum = sum + total;
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Neçə pors dönər istəyirsiniz?");
                    piece = Convert.ToInt32(Console.ReadLine());
                    total = piece * 1.2;
                    sum = sum + total;
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Neçə ədəd su istəyirsiniz?");
                    piece = Convert.ToInt32(Console.ReadLine());
                    total = piece * 0.5;
                    sum = sum + total;
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Neçə ədəd ayran istəyirsiniz?");
                    piece = Convert.ToInt32(Console.ReadLine());
                    total = piece * 0.7;
                    sum = sum + total;
                }
                else if (choice == 7)
                {
                    Console.WriteLine("Neçə ədəd kola istəyirsiniz?");
                    piece = Convert.ToInt32(Console.ReadLine());
                    total = piece * 1.0;
                    sum = sum + total;
                }
                else if (choice == 8)
                {
                    Console.WriteLine("Neçə ədəd çay istəyirsiniz?");
                    piece = Convert.ToInt32(Console.ReadLine());
                    total = piece * 0.5;
                    sum = sum + total;
                }
                else if (choice == 0)
                {
                    Console.WriteLine("\nTəşəkkürlər. Çıxış üçün hər hansı bir düyməni basın.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                    Console.WriteLine("\nZəhmət olmasa mövcud variantlardan birini seçin.\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Başqa bir istəyiniz varmı? (yes/no)");
                Console.ForegroundColor = ConsoleColor.White;
                string answer = Console.ReadLine();
                if (answer == "no" || answer == "n" || answer == "N" || answer == "NO" || answer == "No")
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n**Toplam borcunuz " + sum + "AZN-dir.**");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nÖdəyəcəyiniz məbləği daxil edin (AZN): ");
            double money = Convert.ToDouble(Console.ReadLine());
            if (money > sum)
            {
                var result = money - sum;
                Console.WriteLine("Qalıq: " + result + "AZN");
                Console.WriteLine("\nTəşəkkürlər. Çıxış üçün hər hansı bir düyməni basın.");
            }
            else
            {
                Console.WriteLine("Qabları yu! :D");
            }
            Console.ReadLine();
        }
    }
}