
using System;
using System.Collections.Generic;
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
    }
}