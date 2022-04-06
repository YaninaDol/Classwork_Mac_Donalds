using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_05_04
{
    class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Stazh { get; set; }


        
        public Worker(string name, string surname, int ztazh)
        {
            Name = name;
            Surname = surname;
            this.Stazh = ztazh;
        }
        public Worker() :this("Name","Surname",2)
        {

        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname} \n"); 
        }
    }
}
