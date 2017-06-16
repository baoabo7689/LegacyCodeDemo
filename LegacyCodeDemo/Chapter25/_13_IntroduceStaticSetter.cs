using System.Collections.Generic;
using System.IO;

namespace Chapter25.IntroduceStaticSetter
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Locator
    {
        public static Locator instance;

        public static Locator Instance
        {
            get
            {
                return instance ?? new Locator();
            }
        }

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

        public void Move()
        {
            location = Locator.Instance.GetNextLocation();
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

namespace Chapter25.IntroduceStaticSetter_1
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Locator
    {
        public static Locator instance;

        public static Locator Instance
        {
            get
            {
                return instance ?? new Locator();
            }
        }

        public List<Location> locations;

        public int index = 0;

        protected Locator()
        {

        }

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

        public void Move()
        {
            location = Locator.Instance.GetNextLocation();
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

namespace Chapter25.IntroduceStaticSetter_2
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Locator
    {
        public static Locator instance;

        public static Locator Instance
        {
            get
            {
                return instance ?? new Locator();
            }
        }

        public List<Location> locations;

        public int index = 0;

        protected Locator()
        {

        }

        public static void SetInstance(Locator locator)
        {
            instance = null;

            instance = locator;
        }

        public Location GetNextLocation()
        {
            var lines = File.ReadAllLines("Locations.txt");
            // ...

            return locations[index++];
        }
    }

    public class TestLocator : Locator
    {
        public new Location GetNextLocation()
        {
            return null;
        }
    }

    public class Car
    {
        private Location location;

        public void Move()
        {
            location = Locator.Instance.GetNextLocation();
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            Locator.SetInstance(new TestLocator());
            var car = new Car();

            // Act
            car.Move();

            // ...
        }
    }
}
