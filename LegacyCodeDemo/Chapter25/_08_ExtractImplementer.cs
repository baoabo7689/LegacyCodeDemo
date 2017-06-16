using System.IO;
using NSubstitute;

namespace Chapter25.ExtractImplementer
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

namespace Chapter25.ExtractImplementer_1
{
    public class Logger
    {
        private string logPath = "Log.txt";

        public void WriteLog(string message)
        {
            File.WriteAllText(logPath, message);
        }
    }

    public class LoggerProduction
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

//namespace Chapter25.ExtractImplementer_2
//{
//    public class Logger
//    {
//        public void WriteLog(string message)
//        {
//            File.WriteAllText(logPath, message);
//        }
//    }

//    public class LoggerProduction
//    {
//        public void WriteLog(string message)
//        {
//            File.WriteAllText("Log.txt", message);
//        }
//    }

//    public class Cashier
//    {
//        private Logger logger;

//        public Cashier(Logger logger)
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

//namespace Chapter25.ExtractImplementer_3
//{
//    public abstract class Logger
//    {
//        public abstract void WriteLog(string message); // Care this step: subclass override this method
//    }

//    public class LoggerProduction
//    {
//        public void WriteLog(string message)
//        {
//            File.WriteAllText("Log.txt", message);
//        }
//    }

//    public class Cashier
//    {
//        private Logger logger;

//        public Cashier(Logger logger)
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

//namespace Chapter25.ExtractImplementer_4
//{
//    public abstract class Logger
//    {
//        // Remove using System.IO
//        public abstract void WriteLog(string message);
//    }

//    public class LoggerProduction
//    {
//        public void WriteLog(string message)
//        {
//            File.WriteAllText("Log.txt", message);
//        }
//    }

//    public class Cashier
//    {
//        private Logger logger;

//        public Cashier(Logger logger)
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

//namespace Chapter25.ExtractImplementer_5_6
//{
//    public abstract class Logger
//    {
//        public abstract void WriteLog(string message);
//    }

//    public class LoggerProduction : Logger
//    {
//        public override void WriteLog(string message)
//        {
//            File.WriteAllText("Log.txt", message);
//        }
//    }

//    public class Cashier
//    {
//        private Logger logger;

//        public Cashier(Logger logger)
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

namespace Chapter25.ExtractImplementer_7
{
    public abstract class Logger
    {
        public abstract void WriteLog(string message);
    }

    public class LoggerProduction : Logger
    {
        public override void WriteLog(string message)
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
            var logger = Substitute.For<Logger>();
            var cashier = new Cashier(logger);

            // Act
            cashier.MakeBill((decimal)10); // Error
        }
    }
}