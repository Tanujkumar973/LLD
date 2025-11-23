using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingLot
    {
        private static ParkingLot _instance;
        private List<Level> _levels;
        private ParkingLot()
        {
            _levels = new List<Level>();
        }
        public static ParkingLot GetInstance()
        {
            if (_instance == null)
            {
              
                return new ParkingLot();
            }
            return _instance;
        }

        public void AddLevel(Level level)
        {
            _levels.Add(level);
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            lock (_levels)
            {
                foreach (var level in _levels)
                {
                    if (level.ParkVehicle(vehicle) )
                    {
                        Console.WriteLine($"Vehicle parked successfully at level {level.GetLevelId()}");
                        return true;
                    }
                }
            }     
            Console.WriteLine("Unable to park vehicle");
            return false;
        }

        public bool UnParkVehicle(Vehicle vehicle)
        {
           lock(_levels)
            {
                foreach (var level in _levels)
                {
                    if (level.UnParkVehicle(vehicle))
                    {
                        Console.WriteLine($"Vehicle unparked successfully at level {level.GetLevelId()}");
                        return true;
                    }
                }
            }
            Console.WriteLine("Unable to unpark vehicle");
            return false;
        }

        public void DisplayAvailability()
        {
            foreach(var level in _levels)
            {
                level.PrintAvailability();
            }
        }
    }
}
