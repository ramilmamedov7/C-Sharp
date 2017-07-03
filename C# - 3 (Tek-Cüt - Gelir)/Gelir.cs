using System;

namespace Alqoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            int gelir, gun, brutg;
            double  faiz, netg;
            Console.WriteLine("Gunluk geliri daxil edin: ");
            gelir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gun sayini daxil edin: ");
            gun = Convert.ToInt32(Console.ReadLine());
            brutg = gelir * gun;
            if (brutg >= 1000)
            {
                faiz = brutg * 0.18;
            }
            else
            {
                faiz = brutg * 0.04;
            }
            netg = brutg - faiz;
            Console.WriteLine("Faiz: " + faiz.ToString() + " " +  "Net Gelir: " + netg.ToString());
            Console.ReadLine();
        }
    }
}