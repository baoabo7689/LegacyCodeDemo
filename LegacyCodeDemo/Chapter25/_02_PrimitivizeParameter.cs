using System.IO;
using NUnit.Framework;

namespace Chapter25.PrimitivizeParameter_1
{
    public class FileModel
    {
        public string Content { get; set; }

        public string Extension { get; set; }

        public FileModel(string filePath)
        {
            Content = string.Join("\r\n", File.ReadAllLines(filePath));
            Extension = new FileInfo(filePath).Extension;
        }

        public bool Compare(FileModel comparedFile)
        {
            return Content == comparedFile.Content && Extension == comparedFile.Extension;
        }
    }
}

namespace Chapter25.PrimitivizeParameter_2
{
    public class FileModel
    {
        public string Content { get; set; }

        public string Extension { get; set; }

        public FileModel(string filePath)
        {
            Content = string.Join("\r\n", File.ReadAllLines(filePath));
            Extension = new FileInfo(filePath).Extension;
        }

        public bool Compare(FileModel comparedFile)
        {
            var content1 = new[] { Content, Extension };
            var content2 = new[] { comparedFile.Content, comparedFile.Extension };

            return FileComparer.Compare(content1, content2);
        }
    }

    public static class FileComparer
    {
        public static bool Compare(string[] content1, string[] content2)
        {
            return content1 == content2;
        }
    }

    public class FileComparerTests
    {
        [Test]
        public void Compare_Always_XXX()
        {
            // Arrange
            var content1 = new[] { "Content", "Extension" };
            var content2 = new[] { "Content", "Extension" };

            // Act
            var actualValue = FileComparer.Compare(content1, content2);

            // ...
        }
    }
}
