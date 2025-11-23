using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public abstract class Vehicle
    {
        private string _regNo;
        private VehicleType _type;

        public Vehicle(string regNo, VehicleType type)
        {
            _regNo = regNo;
            _type = type;
        }
        public VehicleType GetVehicleType()
        {
            return _type;
        }
    }
}
