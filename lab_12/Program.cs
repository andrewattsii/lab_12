using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Program
    {
        static void Main(string[] args)
        {

            Person pers1 = new Person("Andre", "123450 Beach Daily Dr. Taylor Mi 23455");
            Student stud1 = new Student("Dan", "2654 Crosswalk Ave. Albuquerque, New Mexico.", 2009, 9234.45);
            Staff staff1 = new Staff("Barathius","XXVIVII Military Ave, Athens Greece IIVIXIII","Grand Circus", 5034.23);

            Console.WriteLine($"{pers1}\n\n{stud1}\n\n{staff1}");
           




        }
    }
}
