using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_ns
{
    class Files
    {
        private string lastAccessDate;
        private int countGet;
        //public string lastChangeDate;

        private static int say;
        public static int getSay()
        {
            return say;
        }
        public void sayArtir()
        {
            say++;
        }

         
        public string LastAccessDate
        {
            set{
                if (value == "15")
                {
                    countGet++;
                    this.lastAccessDate = value;
                }
            }
            get
            {
                return this.lastAccessDate;
            }
        }

        public int CountGet
        {
            set
            {
                this.countGet = value;
            }
            get
            {
                return this.countGet;
            }
        }
        
    }
}
