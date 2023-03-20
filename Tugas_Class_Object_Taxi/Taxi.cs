using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Class_Object_Taxi
{
    public class Taxi
    {
        //Properties
        public string DriverName { get; set; }
        public Boolean Onduty { get; set; }
        public int NumPassanger { get; set; }

        //Method
       public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (Onduty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else if (Onduty == false)
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Num Passangger : {0}", NumPassanger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
