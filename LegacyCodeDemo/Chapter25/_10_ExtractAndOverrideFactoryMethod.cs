using System.IO;

namespace Chapter25.ExtractAndOverrideFactoryMethod
{
    public class FileController
    {
        private StreamReader file;

        public FileController(string path)
        {
            file = File.OpenText(path);
        }

        public bool IsSupport(string extension)
        {
            return extension == "txt";
        }
    }

    public class FileControllerTests
    {
        public void IsSupport_XXX_XXX()
        {
            // Arrange
            var extension = "abc";
            var fileController = new FileController("SomePath"); // Error

            // Act
            fileController.IsSupport(extension);

            // ...
        }
    }
}

namespace Chapter25.ExtractAndOverrideFactoryMethod_1
{
    public class FileController
    {
        private StreamReader file;

        public FileController(string path)
        {
            file = File.OpenText(path);
        }

        public bool IsSupport(string extension)
        {
            return extension == "txt";
        }
    }

    public class FileControllerTests
    {
        public void IsSupport_XXX_XXX()
        {
            // Arrange
            var extension = "abc";
            var fileController = new FileController("SomePath"); // Error

            // Act
            fileController.IsSupport(extension);

            // ...
        }
    }
}

namespace Chapter25.ExtractAndOverrideFactoryMethod_2
{
    public class FileController
    {
        private StreamReader file;

        public FileController(string path)
        {
            CreateInstanceField(path);
        }

        protected void CreateInstanceField(string path)
        {
            file = File.OpenText(path);
        }

        public bool IsSupport(string extension)
        {
            return extension == "txt";
        }
    }

    public class FileControllerTests
    {
        public void IsSupport_XXX_XXX()
        {
            // Arrange
            var extension = "abc";
            var fileController = new FileController("SomePath"); // Error

            // Act
            fileController.IsSupport(extension);

            // ...
        }
    }
}

namespace Chapter25.ExtractAndOverrideFactoryMethod_3
{
    public class FileController
    {
        protected StreamReader file;

        public FileController(string path)
        {
            CreateInstanceField(path);
        }

        protected virtual void CreateInstanceField(string path)
        {
            file = File.OpenText(path);
        }

        public bool IsSupport(string extension)
        {
            return extension == "txt";
        }
    }

    public class TestingFileController : FileController
    {
        public TestingFileController(string path) : base(path)
        {
        }

        protected override void CreateInstanceField(string path)
        {
            file = null;
        }
    }

    public class FileControllerTests
    {
        public void IsSupport_XXX_XXX()
        {
            // Arrange
            var extension = "abc";
            var fileController = new FileController("SomePath");

            // Act
            fileController.IsSupport(extension);

            // ...
        }
    }
}
