using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Level
    {
        private List<ParkingSpot> _parkingspots;
        private int _level;
        public Level( int level, int noOfSpots)
        {
            _parkingspots = new List<ParkingSpot>();
            _level = level;
            int half = noOfSpots / 2;
            for(int i = 0; i < half; i++)
            {
                _parkingspots.Add(new ParkingSpot(i, VehicleType.CAR));
            }
            for (int i = half; i < noOfSpots; i++)
            {
                _parkingspots.Add(new ParkingSpot(i, VehicleType.MOTORCYCLE));
            }
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            foreach(var item in  _parkingspots)
            {
                if (item.IsAvailable() && vehicle.GetVehicleType() == item.GetVehicleType())
                {
                    item.ParkVehicle(vehicle);
                    return true;
                }
            }
            return false;
        }

        public bool UnParkVehicle(Vehicle vehicle)
        {
            foreach(var item in _parkingspots)
            {
                if(!item.IsAvailable() && item.GetVehicle().Equals(vehicle))
                {
                    item.UnParkVehicle();
                    return true;
                }
            }
            return false;
        }

        public int GetLevelId()
        {
            return _level;
        }
        public void PrintAvailability()
        {
            foreach(var item in _parkingspots)
            {
                Console.WriteLine($"Parking spot Availability(Level : {_level} ) - {item.IsAvailable()}");
            }
        }
    }
}
