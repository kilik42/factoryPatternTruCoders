using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    class Car: IVehicle
    {
        public Car()
        {

        }

        public void Drive()
        {
            Console.WriteLine("the car is driving !  Wooo!");


        }
    }
}
