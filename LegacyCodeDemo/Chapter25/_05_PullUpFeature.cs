using System.Collections.Generic;
using System.IO;

namespace Chapter25.PullUpFeature_1
{
    public class Car
    {
        public void Move()
        {
            var nextLocation = GetNextLocation();
            // Check Location, Move...
        }

        public Location GetNextLocation()
        {
            var locator = new Locator();

            return locator.GetNextLocation();
        }
    }

    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Locator
    {
        public List<Location> locations;

        public int index = 0;

        public Locator()
        {
            var locations = File.ReadAllLines("Locations.txt");
            // ...
        }

        public Location GetNextLocation()
        {
            return locations[index++];
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

namespace Chapter25.PullUpFeature_2_3_4
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Locator
    {
        public List<Location> locations;

        public int index = 0;

        public Locator()
        {
            var locations = File.ReadAllLines("Locations.txt");
            // ...
        }

        public Location GetNextLocation()
        {
            return locations[index++];
        }
    }

    public abstract class Vehicle
    {
        public void Move()
        {
            var nextLocation = GetNextLocation();
            // Check Location, Move...
        }

        public abstract Location GetNextLocation();
    }

    public class Car
    {
        public void Move()
        {
            var nextLocation = GetNextLocation();
            // Check Location, Move...
        }

        public Location GetNextLocation()
        {
            var locator = new Locator();

            return locator.GetNextLocation();
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

namespace Chapter25.PullUpFeature_5
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Locator
    {
        public List<Location> locations;

        public int index = 0;

        public Locator()
        {
            var locations = File.ReadAllLines("Locations.txt");
            // ...
        }

        public Location GetNextLocation()
        {
            return locations[index++];
        }
    }

    public abstract class Vehicle
    {
        public void Move()
        {
            var nextLocation = GetNextLocation();
            // Check Location, Move...
        }

        public abstract Location GetNextLocation();
    }

    public class Car : Vehicle
    {
        public override Location GetNextLocation()
        {
            var locator = new Locator();

            return locator.GetNextLocation();
        }
    }

    public class CarMock : Vehicle
    {
        public override Location GetNextLocation()
        {
            return new Location();
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var car = new CarMock();

            // Act
            car.Move();

            // ...
        }
    }
}

