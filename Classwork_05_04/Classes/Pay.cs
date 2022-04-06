using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_05_04
{
    class Pay
    {
       
        public int Hour_Pay { get; set; }


        public Pay(Worker person)
        {
            if (person.Stazh < 1)
                this.Hour_Pay = 40;
            if (person.Stazh<3)
            {
                this.Hour_Pay = 60;
            }
                
                else
            {
                this.Hour_Pay = 100;
            }
           
        }

        public int Payment(int hours)
        {
            return this.Hour_Pay * hours;
        }
    }
}
