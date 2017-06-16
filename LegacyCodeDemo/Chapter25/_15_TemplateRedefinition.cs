namespace Chapter25.TemplateRedefinition_1
{
    public class Machine
    {
        public void Run()
        {
            // Read File
        }
    }

    public class Car
    {
        private Machine machine;

        public void Run()
        {
            machine.Run();

            // ...
        }
    }

    public class CarTests
    {
        public void Run_XXX_XXX()
        {
            // Arrange
            var car = new Car();

            // Act
            car.Run(); // Error

            // ...
        }
    }
}

namespace Chapter25.TemplateRedefinition_2
{
    public class Machine
    {
        public void Run()
        {
            // Read File
        }
    }

    public class Car<T> where T : Machine
    {
        private T machine;

        public void Run()
        {
            machine.Run();

            // ...
        }
    }

    public class CarTests
    {
        public void Run_XXX_XXX()
        {
            // Arrange
            var car = new Car<Machine>();

            // Act
            car.Run(); // Error

            // ...
        }
    }
}

namespace Chapter25.TemplateRedefinition_3
{
    public class Machine
    {
        public void Run()
        {
            // Read File
        }
    }

    public class CarImpl<T> where T : Machine
    {
        private T machine;

        public void Run()
        {
            machine.Run();

            // ...
        }
    }

    public class CarTests
    {
        public void Run_XXX_XXX()
        {
            // Arrange
            var car = new CarImpl<Machine>();

            // Act
            car.Run(); // Error

            // ...
        }
    }
}

namespace Chapter25.TemplateRedefinition_4
{
    public class Machine
    {
        public void Run()
        {
            // Read File
        }
    }

    public class CarImpl<T> where T : Machine
    {
        private T machine;

        public void Run()
        {
            machine.Run();

            // ...
        }
    }

    public class Car : CarImpl<Machine>
    {
    }

    public class CarTests
    {
        public void Run_XXX_XXX()
        {
            // Arrange
            var car = new Car();

            // Act
            car.Run(); // Error

            // ...
        }
    }
}

namespace Chapter25.TemplateRedefinition_5
{
    public class Machine
    {
        public void Run()
        {
            // Read File
        }
    }

    public class CarImpl<T> where T : Machine
    {
        private T machine;

        public void Run()
        {
            machine.Run();

            // ...
        }
    }

    public class Car : CarImpl<Machine>
    {
    }

    public class TestingMachine : Machine
    {
        public new void Run()
        {
            // ...
        }
    }

    public class CarTests
    {
        public void Run_XXX_XXX()
        {
            // Arrange
            var car = new CarImpl<TestingMachine>();

            // Act
            car.Run(); // Error

            // ...
        }
    }
}