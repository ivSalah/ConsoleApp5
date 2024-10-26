using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Vehicle
    {
        public string brand;
    }


    class motorVehicle :Vehicle
        {
            public string modelName;
        }
        class Car:motorVehicle
        {

        }
        class truck:motorVehicle
        {

        }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.brand = "Toyota";
            myCar.modelName = "supra";
            truck MyTruck = new truck();
            MyTruck.brand = "Volvo";
            MyTruck.modelName = "FH16";
            Console.WriteLine(myCar.brand);
            Console.WriteLine(myCar.modelName);
            Console.WriteLine(MyTruck.brand);
            Console.WriteLine(MyTruck.modelName);

            Console.ReadLine();


        }
    }
}
