using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uber
{
    class Person
    {
        //Person dannilari
        public string fullName { get; set; }
        public int startPointX, startPointY, endPointX, endPointY;
        static double distance, taxiDistance;
        private int time, travelTimeOfTaxi;
        private double money;

        public void customer()
        {
            Console.WriteLine("Please enter your name: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Add your coordinates (X): ");
            startPointX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add your coordinates (Y): ");
            startPointY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add coordinates of your destination (X): ");
            endPointX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add coordinates of your destination (Y): ");
            endPointY = Convert.ToInt32(Console.ReadLine());
        }

        //Calculations

        public double DistanceCalculator()
        {
            distance = Math.Sqrt(Math.Pow((endPointX * 1000 - startPointX * 1000), 2) + Math.Pow((endPointY * 1000 - endPointY * 1000), 2));
            return distance;
        }
        public double CalculateMoney()
        {
            money = DistanceCalculator() * 2 / 10000;
            return money;
        }
        public int TimeCalculator()
        {
            time = Convert.ToInt32(DistanceCalculator() / 3000);
            return time;
        }
        public int CalculateTravelTimeOfTaxi(Taxi randomTaxi)
        {
            taxiDistance = Math.Sqrt(Math.Pow((startPointX * 1000 - randomTaxi.taxiCoorX * 1000), 2) + Math.Pow((startPointY * 1000 - randomTaxi.taxiCoorY), 2));
            travelTimeOfTaxi = Convert.ToInt32(taxiDistance / 3000);
            return travelTimeOfTaxi;
        }

        public Person()
        {
            chooseTaxi();
            customer();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n" + "Hormetli {0} sizin taksiniz teyin edildi." + "\n" + "Taksiniz {1} deqiqeye adresinizde olacaq, " + "qeyd etdiyiniz adrese catma vaxtiniz {2} deqiqe. " + "\n" + "Gedish haqqiniz {3}[AZN] olacaqdir." + "\n" + "Size xidmet edecek surucu {4}." + "\n" + "\n", fullName, CalculateTravelTimeOfTaxi(chooseTaxi()), TimeCalculator().ToString(), CalculateMoney().ToString(), chooseTaxi().driverName);
            Console.ReadLine();
        }
        public Taxi chooseTaxi()
        {
            Taxi taxi1 = new Taxi("Bibish", 50, 50);
            Taxi taxi2 = new Taxi("Yumosh", 30, 20);
            Taxi taxi3 = new Taxi("Cappy", 70, 90);
            Taxi taxi4 = new Taxi("Imish", 40, 40);

            Taxi chosenTaxi = taxi1;
            List<Taxi> taxiler = new List<Taxi>();

            taxiler.Add(taxi1);
            taxiler.Add(taxi2);
            taxiler.Add(taxi3);
            taxiler.Add(taxi4);

            int sech = CalculateTravelTimeOfTaxi(taxiler[0]);

            for (int i = 0; i < taxiler.Count; i++)
            {
                if (sech > CalculateTravelTimeOfTaxi(taxiler[i]))
                {
                    sech = CalculateTravelTimeOfTaxi(taxiler[i]);
                    chosenTaxi = taxiler[i];
                }
            }
            return chosenTaxi;


        }
    }
    //Driver dannilari
    class Taxi
    {
        public string driverName { get; set; }
        public int taxiCoorX { get; set; }
        public int taxiCoorY { get; set; }
        public Taxi(string name, int x, int y)
        {
            this.driverName = name;
            this.taxiCoorX = x;
            this.taxiCoorY = y;
        }
    }
}
