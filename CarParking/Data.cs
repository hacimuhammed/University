using CarParking.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParking
{
    public class Parking
    {
        public Pricing prices = new Pricing();
        public VehicleType type { get; set; } = VehicleType.Car;
    }



}
