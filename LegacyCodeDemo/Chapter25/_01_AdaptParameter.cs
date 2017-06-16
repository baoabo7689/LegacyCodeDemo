using System;
using System.Linq;
using System.Web;
using NSubstitute;
using NUnit.Framework;

namespace Chapter25.AdaptParameter_1
{
    public class SystemController
    {
        public void HandlErrors(HttpContext context)
        {
            var errors = context.Error;

            // ...
        }
    }
}

namespace Chapter25.AdaptParameter_2
{
    public interface SystemInfo
    {
        Exception[] Errors();
    }

    public class WebSystemInfo : SystemInfo
    {
        public Exception[] Errors() => HttpContext.Current.AllErrors;
    }

    public class SystemController
    {
        public void HandlErrors(SystemInfo systemInfo)
        {
            var errors = systemInfo.Errors();

            // ...
        }
    }

    public class SystemControllerTests
    {
        [Test]
        public void HandlErrors_Always_XXX()
        {
            // Arrange
            var systemInfo = Substitute.For<SystemInfo>();
            systemInfo.Errors().Returns(Enumerable.Empty<Exception>());

            var systemController = new SystemController();

            // Act
            systemController.HandlErrors(systemInfo);
        }
    }
}
