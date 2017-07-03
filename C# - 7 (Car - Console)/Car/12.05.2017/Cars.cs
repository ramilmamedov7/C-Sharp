using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._05._2017
{
    class Cars
    {
        private double localDistance;
        private double globalDistance;
        private double fuelUsage;
        private uint fuelCapacity;
        private double fuelCurrent;

        public double LocalDistance
        {
            set
            {
                this.localDistance = value;
            }
            get
            {
                return this.localDistance;
            }
        }
        
        public double GlobalDistance
        {
            get
            {
                return this.globalDistance;
            }
        }

        public double FuelUsage
        {
            set
            {
                this.fuelUsage = value;
            }
            get
            {
                return this.fuelUsage;
            }
        }

        public uint FuelCapacity
        {
            set
            {
                this.fuelCapacity = value;
            }
            get
            {
                return this.fuelCapacity;
            }
        }


        /// <summary>
        ///  Yoxlayirki bakda olan benzin-e elave olundugu halda bak movcudlugunda cox olur mu olmayirmi
        /// </summary>
        /// <param name="litr">Ne qeder benzin elave edilmek istendiyi gonedrilecek</param>
        /// <returns></returns>
        public bool checkFuelAviable(double litr)
        {
            if (this.fuelCurrent + litr <= this.FuelCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Baka benzin elave edir
        /// </summary>
        /// <param name="litr">Elave edilecek benzin miqdari</param>
        /// <returns></returns>
        public bool addFuel(double litr)
        {
            if (this.checkFuelAviable(litr))
            {
                this.fuelCurrent += litr;
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Global distance artirir
        /// </summary>
        /// <param name="km"></param>
        public void ascGlobalDistance(double km)
        {
            this.globalDistance += km;
        }
        /// <summary>
        /// Local distance atirir
        /// </summary>
        /// <param name="km"></param>
        public void ascLocalDistance(double km)
        {
            this.LocalDistance += km;
        }
        /// <summary>
        /// Movcud benzin-le nece km yol gedile bileceyini qayatrir
        /// </summary>
        /// <returns></returns>
        public double possibleDistance()
        {
            return (this.fuelCurrent*100)/this.FuelUsage;
        }
        /// <summary>
        ///  Girilen km gedib gede bilmeyeyeceni tapan funksiya 
        /// </summary>
        /// <param name="km"></param>
        /// <returns></returns>
        public bool checkDistance(double km)
        {
            if (this.possibleDistance() <= km)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //public bool checkCanitReach (double km)
        //{
        //    if (this.fuelCurrent<=)
        //}
    }
}
