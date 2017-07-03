using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Patient
    {
        string pName {set; get;}
        public Patient(string name)
        {
            this.pName = name;
        }
    }

    class Doctor
    {
        public string fullName;
        List<string> availableHours = new List<string>();

        public Doctor(string name)
        {
            this.fullName = name;

        }
        public Doctor()
        {

        }
        public void addAvailableH()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            availableHours.Add("(08:00 - 10:00) Full");
            availableHours.Add("(10:00 - 12:00) Empty");
            availableHours.Add("(12:00 - 14:00) Full");
            availableHours.Add("(14:00 - 16:00) Full");
            availableHours.Add("(16:00 - 18:00) Empty");
        }
        public void showAvailableH()
        {
            for (int i = 0; i < availableHours.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + availableHours[i]);
            }
        }
        public void chooseAvailableH(int chooseHourse)
        {
            for (int i = 0; i < availableHours.Count; i++)
            {
                if (chooseHourse - 1 == i)
                {
                    
                    if (availableHours[i].Contains("Full"))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine("\nThe doctor is busy at this time. \nPlease select another time for meeting...\n\nPress `A` to go back to department.\nPress `B` to show doctor's available hours again.");
                    }
                    if (availableHours[i].Contains("Empty"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("\nThank you. You reserved.\n");
                    }
                    else
                    {
                        availableHours[i] = availableHours[i].Replace("Empty", "Full");
                    }
                }
            }
        }
    }
    class Department
    {
        public string name;
        List<Doctor> doctors = new List<Doctor>();
        List<Department> departments = new List<Department>();

        public void AddDepartments()
        {
            departments.Add(new Department("1.Cardiology"));
            departments.Add(new Department("2.Oncology"));
            departments.Add(new Department("3.Physiotherapy"));
            departments.Add(new Department("4.Urology"));
            departments.Add(new Department("5.Gynecology"));

        }
        public void ShowDepartments()
        {
            foreach (var department in departments)
            {
                Console.WriteLine(department.name);
            }
        }

        public void AddDoctors(string chooseShobe)
        {
            if (chooseShobe == "1")
            {
                doctors.Add(new Doctor("1.Lala Memmedova"));
                doctors.Add(new Doctor("2.Ramil Memmedov"));
            }
            else if (chooseShobe == "2")
            {
                doctors.Add(new Doctor("1.Mark Zuckerberg"));
                doctors.Add(new Doctor("2.Filankes Filankesov"));
            }
            else if (chooseShobe == "3")
            {
                doctors.Add(new Doctor("1.Bill Gates"));
                doctors.Add(new Doctor("2.Hans Zimmer"));
            }
            else if (chooseShobe == "4")
            {
                doctors.Add(new Doctor("1.Chester Bannington"));
                doctors.Add(new Doctor("2.Dimebag Darrell"));
            }
            else if (chooseShobe == "5")
            {
                doctors.Add(new Doctor("1.Ehdim Qaqa"));
                doctors.Add(new Doctor("2.Cavidan Sudkolik"));
            }
            else
            {
                Console.WriteLine("Error 404");
            }
        }

        public void ShowDoctors()
        {
            foreach (var doc in doctors)
            {
                Console.WriteLine(doc.fullName);
            }
        }

        public Department(string name)
        {
            this.name = name;
        }
        public Department()
        {

        }
        public Department(string name, List<Doctor> doctors)
        {
            this.name = name;
            this.doctors = doctors;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string cutomerName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWelcome to the Hospital: " + cutomerName);
            var xeste = new Patient(cutomerName);
            var shobe = new Department();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPlease choose the one department you need: \n");
            shobe.AddDepartments();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            shobe.ShowDepartments();
            Console.WriteLine();
            string chooseShobe = Console.ReadLine();
            shobe.AddDoctors(chooseShobe);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nDoctors of number [{0}] department are shown below. \nPlease select your doctor: \n", chooseShobe);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            shobe.ShowDoctors();
            var doc = new Doctor();
            Console.WriteLine();
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPlease reserve time for a meeting: \n");
            doc.addAvailableH();
            doc.showAvailableH();
            Console.WriteLine();
            int chooseHourse = Convert.ToInt32(Console.ReadLine());
            doc.chooseAvailableH(chooseHourse);
            if (Console.ReadKey(true).Key == ConsoleKey.A)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                Console.WriteLine();
                shobe.ShowDepartments();
            }
            if (Console.ReadKey(true).Key == ConsoleKey.B)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                doc.showAvailableH();
                Console.Read();
            }
        }
    }
}