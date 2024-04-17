
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
    }
}