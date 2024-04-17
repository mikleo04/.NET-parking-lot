
using parking_lot.model;

namespace parking_lot.service
{
    public interface IParkinglotService
    {
        void CreateParkingLot(int space);
        void ParkVehicle(Vehicle vehicle);
        void LeaveVehicle(int space);
        void FilledSpaceReport();
        void EmptySpaceReport();
        void VehicleTypeReport(string typeVehicle);
        void LicencePlateTypeReport(string typePlate);
        void ColorTypeReport(string color, string type);
        void FindSpace(string licencePlate);
    }
}