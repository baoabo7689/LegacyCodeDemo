using System.IO;

namespace Chapter25.ParameterizeConstructor
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

//namespace Chapter25.ParameterizeConstructor_1
//{
//    public class FileController
//    {
//        private StreamReader file;

//        public FileController(string path)
//        {
//            file = File.OpenText(path);
//        }

//        public FileController(string path)
//        {
//            file = File.OpenText(path);
//        }

//        public bool IsSupport(string extension)
//        {
//            return extension == "txt";
//        }
//    }

//    public class FileControllerTests
//    {
//        public void IsSupport_XXX_XXX()
//        {
//            // Arrange
//            var extension = "abc";
//            var fileController = new FileController("SomePath"); // Error

//            // Act
//            fileController.IsSupport(extension);

//            // ...
//        }
//    }
//}

namespace Chapter25.ParameterizeConstructor_2
{
    public class FileController
    {
        private StreamReader file;

        public FileController(string path)
        {
            file = File.OpenText(path);
        }

        public FileController(string path, StreamReader file)
        {
            this.file = file;
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

namespace Chapter25.ParameterizeConstructor_3
{
    public class FileController
    {
        private StreamReader file;

        public FileController(string path) : this(path, File.OpenText(path))
        {
        }

        public FileController(string path, StreamReader file)
        {
            this.file = file;
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

namespace Chapter25.ParameterizeConstructor_4
{
    public class FileController
    {
        private StreamReader file;

        public FileController(string path)
        {
            CreateInstanceFields(File.OpenText(path));
        }

        public FileController(string path, StreamReader file)
        {
            CreateInstanceFields(file);
        }

        public void CreateInstanceFields(StreamReader file)
        {
            this.file = file;
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
            var fileController = new FileController("SomePath", null);

            // Act
            fileController.IsSupport(extension);

            // ...
        }
    }
}

