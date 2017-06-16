using System.IO;

namespace Chapter25.IntroduceInstanceDelegator_1
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Locator
    {
        public static Location GetNextLocation()
        {
            var lines = File.ReadAllLines("Locations.txt");
            // ...

            return new Location();
        }
    }

    public class Car
    {
        private Location location;
        private Locator locator;

        public Car()
        {
            locator = new Locator();
        }

        public void Move()
        {
            location = Locator.GetNextLocation();
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var car = new Car();

            // Act
            car.Move(); // Error

            // ...
        }
    }
}

namespace Chapter25.IntroduceInstanceDelegator_2
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Locator
    {
        public static Location GetNextLocation()
        {
            var lines = File.ReadAllLines("Locations.txt");
            // ...

            return new Location();
        }

        public Location GetNextLocationFromFile()
        {
            var lines = File.ReadAllLines("Locations.txt");
            // ...

            return new Location();
        }
    }

    public class Car
    {
        private Location location;
        private Locator locator;

        public Car()
        {
            locator = new Locator();
        }

        public void Move()
        {
            location = Locator.GetNextLocation();
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var car = new Car();

            // Act
            car.Move(); // Error

            // ...
        }
    }
}

namespace Chapter25.IntroduceInstanceDelegator_3
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Locator
    {
        public static Location GetNextLocation()
        {
            var lines = File.ReadAllLines("Locations.txt");
            // ...

            return new Location();
        }

        public Location GetNextLocationFromFile()
        {
            return GetNextLocation();
        }
    }

    public class Car
    {
        private Location location;
        private Locator locator;

        public Car()
        {
            locator = new Locator();
        }

        public void Move()
        {
            location = locator.GetNextLocationFromFile();
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var car = new Car();

            // Act
            car.Move(); // Error

            // ...
        }
    }
}