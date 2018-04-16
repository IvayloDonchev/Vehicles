using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Journey be airplane");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");

            Console.WriteLine("\nJourney by car");
            Car myCar = new Car();
            myCar.StartEngine("Brm Brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");

            Console.WriteLine("\nTesting Polymorphism");
            Vehicle v = myCar;
            v.Drive();  //Motoring
            v = myPlane;
            v.Drive();  //Flying

            Console.ReadKey();
        }
    }
}
