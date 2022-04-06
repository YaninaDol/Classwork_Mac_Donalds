using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_05_04
{
    class Meneger
    {
        IDay[] day_week = new IDay[7];

        public Meneger(Monday one,Tuesday two,Wednesday three,Thursday four,Friday five )
        {
            day_week[0] = one;
            day_week[1] = two;
            day_week[2] = three;
            day_week[3] = four;
            day_week[4] = five;
        }
       
        public IDay this[int ind]
        {
            get { return day_week[ind]; }
           // private set {  }
        }
       
       public void ActualDay()
        {
          this[Convert.ToInt32(DateTime.Now.DayOfWeek)].Today();
        }

        public int Worker_Pay(Worker person,int hours)
        {
             Pay month=new Pay(person);
            return  month.Payment(hours);
        }
    }
}
