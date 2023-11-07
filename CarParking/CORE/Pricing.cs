using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParking.CORE
{

    public class Pricing
    {
        public int Price { get; set; } = 5;
        public int EveryNextHourPrice { get; set; } = 1;
        public int DailyFixedFee { get; set; } = 10;
    }
}
