using System.IO;

namespace Chapter25.ExposeStaticMethod
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Car
    {
        public Car()
        {
            var locations = File.ReadAllLines("Locations.txt");
        }

        public bool CanMove(Location currentLocation, Location nextLocation)
        {
            return currentLocation.X - nextLocation.X < 10;
        }
    }

    public class CarTests
    {
        public void CanMove_XXX_XXX()
        {
            // Arrange
            var car = new Car(); // Error
            var currentLocation = new Location();
            var nextLocation = new Location();

            // Act
            var actualValue = car.CanMove(currentLocation, nextLocation);

            // ...
        }
    }
}

//namespace Chapter25.ExposeStaticMethod_1
//{
//    public class Location
//    {
//        public int X { get; set; }
//        public int Y { get; set; }
//    }

//    public class Car
//    {
//        public Car()
//        {
//            var locations = File.ReadAllLines("Locations.txt");
//        }

//        public bool CanMove(Location currentLocation, Location nextLocation)
//        {
//            return currentLocation.X - nextLocation.X < 10;
//        }
//    }

//    public class CarTests
//    {
//        public void CanMove_XXX_XXX()
//        {
//            // Arrange
//            var car = new Car(); // Error
//            var currentLocation = new Location();
//            var nextLocation = new Location();

//            // Act
//            var actualValue = Car.CanMove(currentLocation, nextLocation);

//            // ...
//        }
//    }
//}

//namespace Chapter25.ExposeStaticMethod_2_3
//{
//    public class Location
//    {
//        public int X { get; set; }
//        public int Y { get; set; }
//    }

//    public class Car
//    {
//        public Car()
//        {
//            var locations = File.ReadAllLines("Locations.txt");
//        }

//        public bool CanMove(Location currentLocation, Location nextLocation)
//        {
//            return CanMoveToNextLocation(currentLocation, nextLocation);
//        }

//        public static bool CanMoveToNextLocation(Location currentLocation, Location nextLocation)
//        {
//            return currentLocation.X - nextLocation.X < 10;
//        }
//    }

//    public class CarTests
//    {
//        public void CanMove_XXX_XXX()
//        {
//            // Arrange
//            var car = new Car(); // Error
//            var currentLocation = new Location();
//            var nextLocation = new Location();

//            // Act
//            var actualValue = Car.CanMove(currentLocation, nextLocation);

//            // ...
//        }
//    }
//}

namespace Chapter25.ExposeStaticMethod_4
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Car
    {
        public Car()
        {
            var locations = File.ReadAllLines("Locations.txt");
        }

        public bool CanMove(Location currentLocation, Location nextLocation)
        {
            return CanMoveToNextLocation(currentLocation, nextLocation);
        }

        public static bool CanMoveToNextLocation(Location currentLocation, Location nextLocation)
        {
            return currentLocation.X - nextLocation.X < 10;
        }
    }

    public class CarTests
    {
        public void CanMove_XXX_XXX()
        {
            // Arrange
            var currentLocation = new Location();
            var nextLocation = new Location();

            // Act
            var actualValue = Car.CanMoveToNextLocation(currentLocation, nextLocation);

            // ...
        }
    }
}