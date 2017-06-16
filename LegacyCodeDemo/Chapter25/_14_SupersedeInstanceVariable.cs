using System.Collections.Generic;
using System.IO;

namespace Chapter25.SupersedeInstanceVariable_1
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

        public Location GetNextLocation()
        {
            var lines = File.ReadAllLines("Locations.txt");
            // ...

            return locations[index++];
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
            location = locator.GetNextLocation();
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

namespace Chapter25.SupersedeInstanceVariable_2
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

        public Location GetNextLocation()
        {
            var lines = File.ReadAllLines("Locations.txt");
            // ...

            return locations[index++];
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
            location = locator.GetNextLocation();
        }

        public void SupersedeLocator(Locator locator)
        {
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

namespace Chapter25.SupersedeInstanceVariable_3
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

        public Location GetNextLocation()
        {
            var lines = File.ReadAllLines("Locations.txt");
            // ...

            return locations[index++];
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
            location = locator.GetNextLocation();
        }

        public void SupersedeLocator(Locator locator)
        {
            this.locator = null;

            this.locator = locator;
        }
    }

    public class TestLocator : Locator
    {
        public new Location GetNextLocation()
        {
            return null;
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var car = new Car();
            car.SupersedeLocator(new TestLocator());

            // Act
            car.Move();

            // ...
        }
    }
}
