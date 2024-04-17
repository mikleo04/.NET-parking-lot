
using System;
using System.Collections.Generic;
using parking_lot.constant;
using parking_lot.model;

namespace parking_lot.service
{
    public class ParkinglotServiceImpl : IParkinglotService
    {
        private List<ParkingSpace> _parkingLot = new();

        public void CreateParkingLot(int space)
        {
            for (int i = 1; i <= space; i++)
            {
                _parkingLot.Add(new ParkingSpace(i));
            }
            Console.WriteLine($"Created a parking lot with {space} slots");
        }
        
        public void ParkVehicle(Vehicle vehicle)
        {
            foreach (ParkingSpace parkingSpace in _parkingLot)
            {
                if (parkingSpace.Status == SpaceStatus.Empty)
                {
                    parkingSpace.Status = SpaceStatus.Filled;
                    parkingSpace.Vehicle = vehicle;
                    Console.WriteLine($"Allocated slot number: {_parkingLot.FindIndex(parking => parking == parkingSpace)+1}");
                    return;
                }
            }
            Console.WriteLine("Sorry, parking lot is full");
        }
    }
}