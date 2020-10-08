using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    class ThreeWheeler:IVehicle
    {

        public void Drive()
        {
            Console.WriteLine("lets get going on our 3 wheeler");
        }
    }
}
