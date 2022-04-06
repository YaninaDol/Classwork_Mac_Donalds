using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_05_04
{
    class First_shift
    {
       public  DateTime start= new DateTime();
       public DateTime end = new DateTime();
       public IWorkplace Workplace;
        public Worker Worker { get; set; }
        public First_shift()
        {
           start.AddHours(+7);
           end.AddHours(+12);
        }
        public First_shift(IWorkplace workplace,Worker person)
        {
            
            this.Workplace = workplace;
            this.Worker = person;           
        }

        public void GetInfo()
        {
            Console.WriteLine(start.AddHours(+7).TimeOfDay);
            Console.WriteLine(end.AddHours(+12).TimeOfDay);

           Workplace.Make();
            Worker.Print();
        }

        
    }
}
