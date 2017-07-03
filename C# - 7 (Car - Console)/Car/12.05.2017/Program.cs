using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._05._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Specify the fuel tank volume: ");
            uint fuelTank = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Calculation of fuel consumption by distance of 100 km: ");
            double consumption = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Add petrol to the car (in liters): ");
            double petrol = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1. How far can I reach with this much fuel?");
            Console.WriteLine("2. Checking if the tank is full or not? To know whether to add more petrol or not.");
            Console.WriteLine("3. Calculate Local distance: ");
            Console.WriteLine("4. Calculate Global distance: ");
            Console.WriteLine("5. Exit!");


            Cars model = new Cars();
            model.FuelUsage = consumption;
            model.FuelCapacity = fuelTank;
            model.addFuel(petrol);

            ushort selection;
            selection = 0;

            do
            {
                selection = Convert.ToUInt16(Console.ReadLine());
                switch (selection)
                {

                    case 1:
                        model.possibleDistance();
                        Console.WriteLine(model.possibleDistance().ToString() + " you can go this many km.");
                        break;
                    case 2:
                        Console.WriteLine("Mark how much petrol you want to add to the fuel tank (in liters): ");
                        double extraFuel;
                        extraFuel = Convert.ToDouble(Console.ReadLine());
                        if (model.checkFuelAviable(extraFuel) == true)
                        {
                            Console.WriteLine(extraFuel + " this much petrol added.");
                        }
                        else
                        {
                            Console.WriteLine("You can't add this much petrol. The fuel tank is full.");
                        }
                        break;

                    case 3:
                        
                        model.possibleDistance();
                        model.ascLocalDistance(model.possibleDistance());
                        Console.WriteLine("Local distance: " + model.LocalDistance.ToString() + "km");
                        Console.WriteLine("Would you like to reset Local distance?");
                        
                        Console.WriteLine("1. Yes");
                        Console.WriteLine("2. No");
                        byte choice = Convert.ToByte(Console.ReadLine());
                        if (choice == 1)
                        {
                            model.LocalDistance = 0;
                            Console.WriteLine("Local distance: " + model.LocalDistance + " km");
                        }
                        break;

                    case 4:
                        model.possibleDistance();
                        model.ascGlobalDistance(model.possibleDistance());
                        Console.WriteLine("Global distance: " + model.GlobalDistance.ToString() + "km");
                        break;
                    
                    case 5:
                        Console.WriteLine("Press any key to exit program.");
                    break;
                    default:
                        Console.WriteLine("asdasd");
                        break;
                }
            } while (selection != 5);

            Console.ReadLine();
        }
    }
}
