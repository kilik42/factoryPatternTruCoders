using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace factoryPattern
{
    class Motorcycle: IVehicle
    {
        public Motorcycle()
        {

        }
        public void Drive()
        {
            Console.WriteLine("the motorcyle is driving at a safe space.");

        }
    }

   
}
