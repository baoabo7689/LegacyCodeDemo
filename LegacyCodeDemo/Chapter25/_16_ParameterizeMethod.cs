namespace Chapter25.ParameterizeMethod
{
    public interface IMachine
    {
        void Run();
    }

    public class Machine : IMachine
    {
        public void Run()
        {
            // Read File
        }
    }

    public class Car
    {
        public void Run()
        {
            var machine = new Machine();

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

//namespace Chapter25.ParameterizeMethod_1
//{
//    public interface IMachine
//    {
//        void Run();
//    }

//    public class Machine : IMachine
//    {
//        public void Run()
//        {
//            // Read File
//        }
//    }

//    public class Car
//    {
//        public void Run()
//        {
//            var machine = new Machine();

//            machine.Run();

//            // ...
//        }

//        public void Run()
//        {
//            var machine = new Machine();

//            machine.Run();

//            // ...
//        }
//    }

//    public class CarTests
//    {
//        public void Run_XXX_XXX()
//        {
//            // Arrange
//            var car = new Car();

//            // Act
//            car.Run(); // Error

//            // ...
//        }
//    }
//}

namespace Chapter25.ParameterizeMethod_2
{
    public interface IMachine
    {
        void Run();
    }

    public class Machine : IMachine
    {
        public void Run()
        {
            // Read File
        }
    }

    public class Car
    {
        public void Run()
        {
            var machine = new Machine();

            machine.Run();

            // ...
        }

        public void Run(IMachine m)
        {
            var machine = m;

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

namespace Chapter25.ParameterizeMethod_3
{
    public interface IMachine
    {
        void Run();
    }

    public class Machine : IMachine
    {
        public void Run()
        {
            // Read File
        }
    }

    public class Car
    {
        public void Run()
        {
            Run(new Machine());
        }

        public void Run(IMachine m)
        {
            var machine = m;

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