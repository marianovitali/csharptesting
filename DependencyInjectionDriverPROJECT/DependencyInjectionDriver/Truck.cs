using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDriver
{
    public class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The driver is driving a truck.");
        }
    }
}
