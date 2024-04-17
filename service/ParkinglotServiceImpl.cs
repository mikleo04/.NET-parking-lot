
using System;
using System.Collections.Generic;
using System.Linq;
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
        
        public void LeaveVehicle(int space)
        {
            ParkingSpace parkingSpace = _parkingLot.ElementAt(space - 1);
            parkingSpace.Status = SpaceStatus.Empty;
            parkingSpace.Vehicle = null;
            Console.WriteLine($"Slot number {space} is free");
        }
        
        public void FilledSpaceReport()
        {
            bool empty = true;
            Console.WriteLine("Slot\tN0.\t \tType\tRegistration No Color");
            foreach (ParkingSpace parkingSpace in _parkingLot)
            {
                if (parkingSpace.Status == SpaceStatus.Filled)
                {
                    Console.Write(parkingSpace.SpaceNumber);
                    Console.Write($"\t{parkingSpace.Vehicle.LicencePlate}");
                    Console.Write($"\t{parkingSpace.Vehicle.Type}");
                    Console.WriteLine($"\t{parkingSpace.Vehicle.Color}");
                    empty = false;
                }
            }

            if (empty)
            {
                Console.WriteLine("All space is empty");
            }
        }
        
        public void EmptySpaceReport()
        {
            List<int> spaceEmpty = new List<int>();
            foreach (ParkingSpace parkingSpace in _parkingLot)
            {
                if (parkingSpace.Status == SpaceStatus.Empty)
                {
                    spaceEmpty.Add(parkingSpace.SpaceNumber);
                }
            }

            if (spaceEmpty.Count > 0)
            {
                Console.WriteLine($"Space: {string.Join(", ", spaceEmpty)}");
            }
            else
            {
                Console.WriteLine("There is no space in parking lot");
            }
        }
    }
}