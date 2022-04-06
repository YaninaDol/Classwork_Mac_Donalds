using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_05_04
{
    class Friday : IDay
    {
        public First_shift first { get; set; }
        public Second_shift second { get; set; }

        public Worker Worker { get; set; }

        public Friday(IWorkplace first_place, Worker one, IWorkplace second_place, Worker two)
        {
          
            first = new First_shift(first_place, one);
            second = new Second_shift(second_place, two);

        }

       

        public void Today()
        {
            Console.WriteLine(" Friday ");

            first.GetInfo();
            second.GetInfo();
        }
    }
}
