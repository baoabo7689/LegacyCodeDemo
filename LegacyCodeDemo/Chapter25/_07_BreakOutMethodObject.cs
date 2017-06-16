using System.Collections.Generic;
using System.IO;
using NSubstitute;

namespace Chapter25.BreakOutMethodObject
{
    public class Car
    {
        private double speed;
        private Location direction;
        private Locator locator;

        public Car()
        {
            locator = new Locator();
        }

        public void Move(Location location)
        {
            if (speed > 0
                && (direction.X != 0 || direction.Y != 0)
                && locator.HasObstacle(location))
            {
                MakeBeep();
            }
        }

        public void MakeBeep()
        {
            // Produce Sound
        }
    }

    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Locator
    {
        public List<Location> obstacles;

        public int index = 0;

        public Locator()
        {
            var obstacles = File.ReadAllLines("Obstacles.txt");
            // ...
        }

        public bool HasObstacle(Location location)
        {
            return obstacles.Contains(location);
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var location = new Location();
            var car = new Car();

            // Act
            car.Move(location); // Error

            // Expect Produce Sound?
        }
    }
}

namespace Chapter25.BreakOutMethodObject_1
{
    public class CarOperator
    {
    }

    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Car
    {
        private double speed;
        private Location direction;
        private Locator locator;

        public Car()
        {
            locator = new Locator();
        }

        public void Move(Location location)
        {
            if (speed > 0
                && (direction.X != 0 || direction.Y != 0)
                && locator.HasObstacle(location))
            {
                MakeBeep();
            }
        }

        public void MakeBeep()
        {
            // Produce Sound
        }
    }

    public class Locator
    {
        public List<Location> obstacles;

        public int index = 0;

        public Locator()
        {
            var obstacles = File.ReadAllLines("Obstacles.txt");
            // ...
        }

        public bool HasObstacle(Location location)
        {
            return obstacles.Contains(location);
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var location = new Location();
            var car = new Car();

            // Act
            car.Move(location); // Error

            // Expect Produce Sound?
        }
    }
}

namespace Chapter25.BreakOutMethodObject_2
{
    public class CarOperator
    {
        public CarOperator(Car car, Location location)
        {
        }
    }

    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Car
    {
        private double speed;
        private Location direction;
        private Locator locator;

        public Car()
        {
            locator = new Locator();
        }

        public void Move(Location location)
        {
            if (speed > 0
                && (direction.X != 0 || direction.Y != 0)
                && locator.HasObstacle(location))
            {
                MakeBeep();
            }
        }

        public void MakeBeep()
        {
            // Produce Sound
        }
    }

    public class Locator
    {
        public List<Location> obstacles;

        public int index = 0;

        public Locator()
        {
            var obstacles = File.ReadAllLines("Obstacles.txt");
            // ...
        }

        public bool HasObstacle(Location location)
        {
            return obstacles.Contains(location);
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var location = new Location();
            var car = new Car();

            // Act
            car.Move(location); // Error

            // Expect Produce Sound?
        }
    }
}

namespace Chapter25.BreakOutMethodObject_3
{
    public class CarOperator
    {
        private Car car;
        private Location location;

        public CarOperator(Car car, Location location)
        {
            this.car = car;
            this.location = location;
        }
    }

    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Car
    {
        private double speed;
        private Location direction;
        private Locator locator;

        public Car()
        {
            locator = new Locator();
        }

        public void Move(Location location)
        {
            if (speed > 0
                && (direction.X != 0 || direction.Y != 0)
                && locator.HasObstacle(location))
            {
                MakeBeep();
            }
        }

        public void MakeBeep()
        {
            // Produce Sound
        }
    }

    public class Locator
    {
        public List<Location> obstacles;

        public int index = 0;

        public Locator()
        {
            var obstacles = File.ReadAllLines("Obstacles.txt");
            // ...
        }

        public bool HasObstacle(Location location)
        {
            return obstacles.Contains(location);
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var location = new Location();
            var car = new Car();

            // Act
            car.Move(location); // Error

            // Expect Produce Sound?
        }
    }
}

namespace Chapter25.BreakOutMethodObject_4
{
    public class CarOperator
    {
        private Car car;
        private Location location;

        public CarOperator(Car car, Location location)
        {
            this.car = car;
            this.location = location;
        }

        public void Run()
        {
        }
    }

    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Car
    {
        private double speed;
        private Location direction;
        private Locator locator;

        public Car()
        {
            locator = new Locator();
        }

        public void Move(Location location)
        {
            if (speed > 0
                && (direction.X != 0 || direction.Y != 0)
                && locator.HasObstacle(location))
            {
                MakeBeep();
            }
        }

        public void MakeBeep()
        {
            // Produce Sound
        }
    }

    public class Locator
    {
        public List<Location> obstacles;

        public int index = 0;

        public Locator()
        {
            var obstacles = File.ReadAllLines("Obstacles.txt");
            // ...
        }

        public bool HasObstacle(Location location)
        {
            return obstacles.Contains(location);
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var location = new Location();
            var car = new Car();

            // Act
            car.Move(location); // Error

            // Expect Produce Sound?
        }
    }
}

namespace Chapter25.BreakOutMethodObject_5
{
    public class CarOperator
    {
        private Car car;
        private Location location;

        public CarOperator(Car car, Location location)
        {
            this.car = car;
            this.location = location;
        }

        public void Run()
        {
            //if (speed > 0
            //      && (direction.X != 0 || direction.Y != 0)
            //      && locator.HasObstacle(location))
            //{
            //    MakeBeep();
            //}
        }
    }

    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Car
    {
        private double speed;
        private Location direction;
        private Locator locator;

        public Car()
        {
            locator = new Locator();
        }

        public void Move(Location location)
        {
            if (speed > 0
                && (direction.X != 0 || direction.Y != 0)
                && locator.HasObstacle(location))
            {
                MakeBeep();
            }
        }

        public void MakeBeep()
        {
            // Produce Sound
        }
    }

    public class Locator
    {
        public List<Location> obstacles;

        public int index = 0;

        public Locator()
        {
            var obstacles = File.ReadAllLines("Obstacles.txt");
            // ...
        }

        public bool HasObstacle(Location location)
        {
            return obstacles.Contains(location);
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var location = new Location();
            var car = new Car();

            // Act
            car.Move(location); // Error

            // Expect Produce Sound?
        }
    }
}

namespace Chapter25.BreakOutMethodObject_6
{
    public class CarOperator
    {
        private Car car;
        private Location location;

        public CarOperator(Car car, Location location)
        {
            this.car = car;
            this.location = location;
        }

        public void Run()
        {
            if (car.GetSpeed() > 0
                  && (car.GetDirection().X != 0 || car.GetDirection().Y != 0)
                  && car.GetLocator().HasObstacle(location))
            {
                car.MakeBeep();
            }
        }
    }

    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Car
    {
        private double speed;
        private Location direction;
        private Locator locator;

        public Car()
        {
            locator = new Locator();
        }

        public void Move(Location location)
        {
            if (speed > 0
                && (direction.X != 0 || direction.Y != 0)
                && locator.HasObstacle(location))
            {
                MakeBeep();
            }
        }

        public void MakeBeep()
        {
            // Produce Sound
        }

        public double GetSpeed() => speed;

        public Location GetDirection() => direction;

        public Locator GetLocator() => locator;
    }

    public class Locator
    {
        public List<Location> obstacles;

        public int index = 0;

        public Locator()
        {
            var obstacles = File.ReadAllLines("Obstacles.txt");
            // ...
        }

        public bool HasObstacle(Location location)
        {
            return obstacles.Contains(location);
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var location = new Location();
            var car = new Car();

            // Act
            car.Move(location); // Error

            // Expect Produce Sound?
        }
    }
}

namespace Chapter25.BreakOutMethodObject_7
{
    public class CarOperator
    {
        private Car car;
        private Location location;

        public CarOperator(Car car, Location location)
        {
            this.car = car;
            this.location = location;
        }

        public void Run()
        {
            if (car.GetSpeed() > 0
                  && (car.GetDirection().X != 0 || car.GetDirection().Y != 0)
                  && car.GetLocator().HasObstacle(location))
            {
                car.MakeBeep();
            }
        }
    }

    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Car
    {
        private double speed;
        private Location direction;
        private Locator locator;

        public Car()
        {
            locator = new Locator();
        }

        public void Move(Location location)
        {
            var carOperator = new CarOperator(this, location);

            carOperator.Run();
        }

        public void MakeBeep()
        {
            // Produce Sound
        }

        public double GetSpeed() => speed;

        public Location GetDirection() => direction;

        public Locator GetLocator() => locator;
    }

    public class Locator
    {
        public List<Location> obstacles;

        public int index = 0;

        public Locator()
        {
            var obstacles = File.ReadAllLines("Obstacles.txt");
            // ...
        }

        public bool HasObstacle(Location location)
        {
            return obstacles.Contains(location);
        }
    }

    public class CarTests
    {
        public void Move_XXX_XXX()
        {
            // Arrange
            var location = new Location();
            var car = new Car();

            // Act
            car.Move(location); // Error

            // Expect Produce Sound?
        }
    }
}


namespace Chapter25.BreakOutMethodObject_8
{
    public interface ICar
    {
        double GetSpeed();

        Location GetDirection();

        Locator GetLocator();

        void MakeBeep();
    }

    public class CarOperator
    {
        private ICar car;
        private Location location;

        public CarOperator(ICar car, Location location)
        {
            this.car = car;
            this.location = location;
        }

        public void Run()
        {
            if (car.GetSpeed() > 0
                  && (car.GetDirection().X != 0 || car.GetDirection().Y != 0)
                  && car.GetLocator().HasObstacle(location))
            {
                car.MakeBeep();
            }
        }
    }

    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Car : ICar
    {
        private double speed;
        private Location direction;
        private Locator locator;

        public Car()
        {
            locator = new Locator();
        }

        public void Move(Location location)
        {
            var carOperator = new CarOperator(this, location);

            carOperator.Run();
        }

        public void MakeBeep()
        {
            // Produce Sound
        }

        public double GetSpeed() => speed;

        public Location GetDirection() => direction;

        public Locator GetLocator() => locator;
    }

    public class Locator
    {
        public List<Location> obstacles;

        public int index = 0;

        public Locator()
        {
            var obstacles = File.ReadAllLines("Obstacles.txt");
            // ...
        }

        public bool HasObstacle(Location location)
        {
            return obstacles.Contains(location);
        }
    }

    public class CarOperatorTests
    {
        public void Run_XXX_XXX()
        {
            // Arrange
            var location = new Location();
            var car = Substitute.For<ICar>();
            var carOperator = new CarOperator(car, location);

            // Act
            carOperator.Run();

            // Expect Produce Sound?
        }
    }
}