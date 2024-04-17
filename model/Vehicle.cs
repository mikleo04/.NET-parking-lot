using parking_lot.constant;

namespace parking_lot.model
{
    public class Vehicle
    {
        public string LicencePlate { set; get; }
        public string Color { set; get; }
        public TypeVehicle Type { set; get; }

        public Vehicle(string licencePlate, string color, TypeVehicle type)
        {
            LicencePlate = licencePlate;
            Color = color;
            Type = type;
        }


        public override string ToString()
        {
            return $"{LicencePlate} {Color} {Type}";
        }
        
    }
    
}