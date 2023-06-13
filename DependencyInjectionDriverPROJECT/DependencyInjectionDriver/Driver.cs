using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDriver
{
    public class Driver
    {
        private readonly IVehicle _vehicle;

        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Drive()
        {
            _vehicle.Drive();
        }
    }

    //public class Driver
    //{
    //    private readonly IVehicle _vehicle;

    //    public Driver()
    //    {

    //        _vehicle = new Truck();
    //    }

    //    public void Drive()
    //    {
    //        _vehicle.Drive();
    //    }
    //}
}
