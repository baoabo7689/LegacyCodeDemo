﻿using System.Collections.Generic;
using System.IO;

namespace Chapter25.SubclassAndOverrideMethod_1
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
            location = GetNextLocation();
        }

        private Location GetNextLocation()
        {
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


namespace Chapter25.SubclassAndOverrideMethod_2
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
            location = GetNextLocation();
        }

        protected virtual Location GetNextLocation()
        {
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

namespace Chapter25.SubclassAndOverrideMethod_3
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
            location = GetNextLocation();
        }

        protected virtual Location GetNextLocation()
        {
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

namespace Chapter25.SubclassAndOverrideMethod_4
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
            location = GetNextLocation();
        }

        protected virtual Location GetNextLocation()
        {
            return locator.GetNextLocation();
        }
    }

    public class TestingCar : Car
    {
        protected override Location GetNextLocation()
        {
            return new Location();
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