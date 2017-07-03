using System;

namespace Alqoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Eded daxil edin:");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Daxil etdiyiniz eded ne tekdir ne cut");
                Console.ReadLine();
            }
            else if ( x % 2 == 0){
                x = x * x;
                Console.WriteLine("Daxil etdiyiniz eded - Cutdur." +  " Kvadrati budur: " + x);
                Console.ReadLine();
            }
            else
            {
                x = x * x * x;
                Console.WriteLine("Daxil etdiyiniz eded - Tekdir." +  " Kubu budur: " + x);
                Console.ReadLine();
            }
        }
    }
}
