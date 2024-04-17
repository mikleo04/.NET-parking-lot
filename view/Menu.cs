using System;
using parking_lot.constant;
using parking_lot.model;
using parking_lot.service;

namespace parking_lot.view
{
    public class Menu
    {
        private IParkinglotService _parkingLotService = new ParkinglotServiceImpl();

        public void Run()
        {
            bool isValid = true;
            do
            {
                Console.Write("~$ ");

                string command = Console.ReadLine();
                if (command !=  null)
                {
                    switch (command)
                    {
                        case not null when command.Contains("create"):
                            string[] valueCreate = command.Split(" ");
                            _parkingLotService.CreateParkingLot(Convert.ToInt32(valueCreate[1]));
                            break;
                        case not null when command.Contains("park"):
                            string[] valuePark = command.Split(" ");
                            _parkingLotService.ParkVehicle(
                                new Vehicle(
                                    valuePark[1],
                                    valuePark[2],
                                    (TypeVehicle)Enum.Parse(typeof(TypeVehicle), valuePark[3])
                                )
                            );
                            break;
                        case not null when command.Contains("leave"):
                            string[] valueLeave = command.Split(" ");
                            _parkingLotService.LeaveVehicle(Convert.ToInt32(valueLeave[1]));
                            break;
                        case not null when command.Contains("status"):
                            _parkingLotService.FilledSpaceReport();
                            break;
                        case not null when command.Contains("available space"):
                            _parkingLotService.EmptySpaceReport();
                            break;
                        case not null when command.Contains("type_of_vehicles Motor"):
                            string[] valueMotor = command.Split(" ");
                            _parkingLotService.VehicleTypeReport(valueMotor[1]);
                            break;
                        case not null when command.Contains("type_of_vehicles Mobil"):
                            string[] valueCar = command.Split(" ");
                            _parkingLotService.VehicleTypeReport(valueCar[1]);
                            break;
                        case not null when command.Contains("registration_numbers_for_vehicles_with_ood_plate"):
                            _parkingLotService.LicencePlateTypeReport("ood");
                            break;
                        case not null when command.Contains("registration_numbers_for_vehicles_with_event_plate"):
                            _parkingLotService.LicencePlateTypeReport("even");
                            break;
                        case not null when command.Contains("registration_numbers_for_vehicles_with_colour"):
                            string[] valueColorTypeForRegis = command.Split(" ");
                            _parkingLotService.ColorTypeReport(valueColorTypeForRegis[1], "licencePlate");
                            break;
                        case not null when command.Contains("slot_numbers_for_vehicles_with_colour"):
                            string[] valueColorTypeForSpace = command.Split(" ");
                            _parkingLotService.ColorTypeReport(valueColorTypeForSpace[1], "spaceNumber");
                            break;
                        case not null when command.Contains("slot_number_for_registration_number"):
                            string[] valueLicencePlate = command.Split(" ");
                            _parkingLotService.FindSpace(valueLicencePlate[1]);
                            break;
                        case not null when command.Contains("exit"):
                            isValid = false;
                            break;
                        default :
                            Console.WriteLine("Command not found");
                            break;
                    }
                }
            } while (isValid);
        }
    }
}