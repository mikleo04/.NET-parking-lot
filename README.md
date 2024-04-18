## PARKING LOT
This is a console project that aims to simulate several processes that occur in a parking lot. In a parking lot there are several parking spaces, the owner of the parking lot can create the number of parking spaces according to his wishes. Incoming vehicles can park their vehicles in parking spaces that have empty status. If the number of parking spaces has been fulfilled then vehicles that have just arrived cannot park their vehicles. Apart from that, parking lot managers can also view parking lot reports based on several aspects.

### Tech
- .NET 5

### Command
- Make parking lot
  
  ```~$ create_parking_lot 6```
- Parking the vehicle
  
  ```~$ park B-1234-XYZ Putih Mobil``` / ```~$ park B-1234-XYZ Putih Motor```
- Vehicle leaves the parking lot
  
  ```~$ leave 2```
- Report on parking lots whose status is filled
  
  ```~$ status```
- Report the number of motorcycles in the parking lot
  
  ```~$ type_of_vehicles Motor```
- Report the number of cars in the parking lot
  
  ```~$ type_of_vehicles Mobil```
- Reports of vehicles that have odd license plates
  
  ```~$ registration_numbers_for_vehicles_with_ood_plate```
- Report a vehicle that has an even number of license plates
  
  ```~$ registration_numbers_for_vehicles_with_event_plate```
- Find vehicle by color
  
  ```~$ registration_numbers_for_vehicles_with_colour Putih```
- Find space number by vehicle color
  
  ```~$ slot_numbers_for_vehicles_with_colour Putih```
- Find vehicle in parking lot by licence plate

  ```~$ slot_number_for_registration_number B-3141-ZZZ```
- exit from the program
  
  ```~$ exit```

### model
- Vehicle
```csharp
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
```
- ParkingSpace
```csharp
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
```

### Enum
- SpaceStatus
```csharp
    public enum SpaceStatus
    {
        Empty,
        Filled
    }
```
- TypeVehicle
```csharp
    public enum TypeVehicle
    {
        Mobil,
        Motor
    }
```
  