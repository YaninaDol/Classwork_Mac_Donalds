using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_05_04
{
    class Second_shift
    {
        DateTime start = new DateTime();
        DateTime end = new DateTime();
        public IWorkplace Workplace;
        public Worker Worker { get; set; }
        public Second_shift()
        {
            start.AddHours(+12);
            end.AddHours(+21);
        }
        public Second_shift(IWorkplace workplace, Worker person)
        {

            this.Workplace = workplace;
            this.Worker = person;
        }
        public void GetInfo()
        {
            Console.WriteLine(start.AddHours(+12).TimeOfDay);
            Console.WriteLine(end.AddHours(+21).TimeOfDay);

            Workplace.Make();
            Worker.Print();
        }
    }
}
