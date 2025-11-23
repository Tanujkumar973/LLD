using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    internal class ParkingLotDemo
    {
    
       public void Run()
        {
            ParkingLot parkingLot = ParkingLot.GetInstance();
            parkingLot.AddLevel(new Level(1, 10));
            parkingLot.AddLevel(new Level(2, 10));
            parkingLot.ParkVehicle(new Car("AP21 3456"));
            parkingLot.DisplayAvailability();
            parkingLot.ParkVehicle(new MotorCycle("AP21 6342"));
            parkingLot.DisplayAvailability();
            parkingLot.ParkVehicle(new MotorCycle("AP21 3590"));
        }
    }
}
