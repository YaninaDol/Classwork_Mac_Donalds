using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_05_04
{
    class Monday:IDay
    {
        public First_shift first { get; set; }
        public Second_shift second { get; set; }
       
      
        public Monday(IWorkplace first_place, Worker one, IWorkplace second_place, Worker two)
        {
            

            first = new First_shift(first_place, one);
            second = new Second_shift(second_place, two);

        }

     
        public void Today()
        {
            Console.WriteLine(" Monday ");

            first.GetInfo();
            second.GetInfo();

        }



    }
}
