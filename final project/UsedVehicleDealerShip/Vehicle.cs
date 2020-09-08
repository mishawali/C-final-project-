using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedVehicleDealerShip
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public double Cost  { get; set; }
        public DateTime SoldDate { get; set; }

        public bool Sold { get; set; }
    }
}
