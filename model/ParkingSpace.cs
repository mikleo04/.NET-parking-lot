using parking_lot.constant;

namespace parking_lot.model
{
    public class ParkingSpace
    {
        public int SpaceNumber { set; get; }
        public SpaceStatus Status { set; get; }
        public Vehicle Vehicle { set; get; }
        
        public ParkingSpace(int spaceNumber)
        {
            SpaceNumber = spaceNumber;
            Status = SpaceStatus.Empty;
            Vehicle = null;
        }
    }
}