using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingSpot
    {
        private int _spotId;
        private Vehicle _vehicle;
        private VehicleType _vehicleType;
        
        public ParkingSpot(int spotId,VehicleType vehicleType)
        {
            _spotId = spotId;
            _vehicleType = vehicleType;
        }

        public bool IsAvailable()
        {
            return _vehicle == null;
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void UnParkVehicle()
        {
            _vehicle = null;
        }
        public int GetSpotId()
        {
            return _spotId;
        }
        public VehicleType GetVehicleType()
        {
            return _vehicleType;
        }
        public Vehicle GetVehicle()
        {
            if(_vehicle != null)
            {
                return _vehicle;
            }
            return null;
        }
    }
}
