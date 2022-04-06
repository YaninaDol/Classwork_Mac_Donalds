using System;

namespace Classwork_05_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker Nazar1 = new Worker("Nazar1", "Kravchuk", 2);
            Worker Nazar2 = new Worker("Nazar2", "Kravchuk", 2);

            Worker Anna1 = new Worker("Anna1", "Kravchuk", 1);
            Worker Anna2 = new Worker("Anna2", "Kravchuk", 1);



            Meneger exampl = new Meneger(new Monday(new French_fries(),Nazar1,new GO_HOME(),Anna1),new Tuesday(new Humburger(),Nazar2,new Ice_cream(),Anna2),new Wednesday(new French_fries(), Anna1, new Humburger(), Nazar1),new Thursday(new Humburger(), Anna2, new Ice_cream(), Nazar2),new Friday(new GO_HOME(), Nazar2, new GO_HOME(), Nazar1));

            exampl[Convert.ToInt32(DateTime.Now.DayOfWeek)].Today();
            
            
            
        }
    }
}
