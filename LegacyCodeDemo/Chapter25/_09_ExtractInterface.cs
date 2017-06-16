using System.IO;
using NSubstitute;

namespace Chapter25.ExtractInterface
{
    public class Logger
    {
        public void WriteLog(string message)
        {
            File.WriteAllText("Log.txt", message);
        }
    }

    public class Cashier
    {
        private Logger logger;

        public Cashier(Logger logger)
        {
            this.logger = logger;
        }

        public void MakeBill(decimal amount)
        {
            logger.WriteLog(amount.ToString());
        }
    }

    public class CashierTests
    {
        public void MakeBill_XXX_XXX()
        {
            // Arrange
            var logger = new Logger();
            var cashier = new Cashier(logger);

            // Act
            cashier.MakeBill((decimal)10); // Error
        }
    }
}

namespace Chapter25.ExtractInterface_1
{
    public interface ILogger
    {
    }

    public class Logger
    {
        public void WriteLog(string message)
        {
            File.WriteAllText("Log.txt", message);
        }
    }

    public class Cashier
    {
        private Logger logger;

        public Cashier(Logger logger)
        {
            this.logger = logger;
        }

        public void MakeBill(decimal amount)
        {
            logger.WriteLog(amount.ToString());
        }
    }

    public class CashierTests
    {
        public void MakeBill_XXX_XXX()
        {
            // Arrange
            var logger = new Logger();
            var cashier = new Cashier(logger);

            // Act
            cashier.MakeBill((decimal)10); // Error
        }
    }
}

namespace Chapter25.ExtractInterface_2
{
    public interface ILogger
    {
    }

    public class Logger : ILogger
    {
        public void WriteLog(string message)
        {
            File.WriteAllText("Log.txt", message);
        }
    }

    public class Cashier
    {
        private Logger logger;

        public Cashier(Logger logger)
        {
            this.logger = logger;
        }

        public void MakeBill(decimal amount)
        {
            logger.WriteLog(amount.ToString());
        }
    }

    public class CashierTests
    {
        public void MakeBill_XXX_XXX()
        {
            // Arrange
            var logger = new Logger();
            var cashier = new Cashier(logger);

            // Act
            cashier.MakeBill((decimal)10); // Error
        }
    }
}

//namespace Chapter25.ExtractInterface_3
//{
//    public interface ILogger
//    {
//    }

//    public class Logger : ILogger
//    {
//        public void WriteLog(string message)
//        {
//            File.WriteAllText("Log.txt", message);
//        }
//    }

//    public class Cashier
//    {
//        private ILogger logger;

//        public Cashier(ILogger logger)
//        {
//            this.logger = logger;
//        }

//        public void MakeBill(decimal amount)
//        {
//            logger.WriteLog(amount.ToString());
//        }
//    }

//    public class CashierTests
//    {
//        public void MakeBill_XXX_XXX()
//        {
//            // Arrange
//            var logger = new Logger();
//            var cashier = new Cashier(logger);

//            // Act
//            cashier.MakeBill((decimal)10); // Error
//        }
//    }
//}

namespace Chapter25.ExtractInterface_4
{
    public interface ILogger
    {
        void WriteLog(string message);
    }

    public class Logger : ILogger
    {
        public void WriteLog(string message)
        {
            File.WriteAllText("Log.txt", message);
        }
    }

    public class Cashier
    {
        private ILogger logger;

        public Cashier(ILogger logger)
        {
            this.logger = logger;
        }

        public void MakeBill(decimal amount)
        {
            logger.WriteLog(amount.ToString());
        }
    }

    public class CashierTests
    {
        public void MakeBill_XXX_XXX()
        {
            // Arrange
            var logger = Substitute.For<ILogger>();
            var cashier = new Cashier(logger);

            // Act
            cashier.MakeBill((decimal)10); // Error
        }
    }
}
