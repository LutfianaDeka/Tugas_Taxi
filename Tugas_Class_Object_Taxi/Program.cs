using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tugas_Class_Object_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek taxi
            Taxi taxi = new Taxi();

            // Pengesetan nilai properties
            taxi.DriverName = "Jono";
            taxi.Onduty = true;
            taxi.NumPassanger = 10;

            // Panggilan method
            taxi.TaxiInfo();

            Console.WriteLine();

            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}