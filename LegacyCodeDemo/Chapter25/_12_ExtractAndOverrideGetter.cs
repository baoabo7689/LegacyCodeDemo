using System.Collections.Generic;
using System.IO;

namespace Chapter25.ExtractAndOverrideGetter_1
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
        private Locator locator;
        private decimal speed;
        private Location location;

        public Car()
        {
            speed = 0;
            locator = new Locator();
        }

        public Car(decimal speed)
        {
            this.speed = speed;
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

namespace Chapter25.ExtractAndOverrideGetter_2
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
        private Locator locator;
        private decimal speed;
        private Location location;

        public Car()
        {
            speed = 0;
            locator = new Locator();
        }

        public Car(decimal speed)
        {
            this.speed = speed;
            locator = new Locator();
        }

        protected virtual Locator Locator
        {
            get
            {
                return new Locator();
            }
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

namespace Chapter25.ExtractAndOverrideGetter_3
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
        private Locator locator;
        private decimal speed;
        private Location location;

        public Car()
        {
            speed = 0;
            locator = null;
        }

        public Car(decimal speed)
        {
            this.speed = speed;
            locator = null;
        }

        protected virtual Locator Locator
        {
            get
            {
                return new Locator();
            }
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

namespace Chapter25.ExtractAndOverrideGetter_4
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
        private Locator locator;
        private decimal speed;
        private Location location;

        public Car()
        {
            speed = 0;
            locator = null;
        }

        public Car(decimal speed)
        {
            this.speed = speed;
            locator = null;
        }

        protected virtual Locator Locator
        {
            get
            {
                if (locator == null)
                {
                    locator = new Locator();
                }

                return locator;
            }
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

namespace Chapter25.ExtractAndOverrideGetter_5
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
        private Locator locator;
        private decimal speed;
        private Location location;

        public Car()
        {
            speed = 0;
            locator = null;
        }

        public Car(decimal speed)
        {
            this.speed = speed;
            locator = null;
        }

        protected virtual Locator Locator
        {
            get
            {
                if (locator == null)
                {
                    locator = new Locator();
                }

                return locator;
            }
        }

        public void Move()
        {
            location = Locator.GetNextLocation();
        }
    }

    public class TestLocator : Locator
    {
        public new Location GetNextLocation()
        {
            return null;
        }
    }

    public class TestingCar : Car
    {
        protected override Locator Locator
        {
            get
            {
                return new TestLocator();
            }
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var car = new TestingCar();

            // Act
            car.Move();

            // ...
        }
    }
}
