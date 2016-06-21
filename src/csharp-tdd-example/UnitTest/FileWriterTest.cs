using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopment;

namespace UnitTest
{
    [TestClass]
    public class FileWriterTest
    {
        [TestMethod]
        public void TestFileWriter()
        {
            var filePath = "./Output_Test.txt";
            var testText = "Hallo Welt!";

            var writer = new FileWriter();

            Assert.IsNotNull(writer);
            Assert.IsInstanceOfType(writer, typeof(FileWriter));

            Assert.IsTrue(new Func<bool>(() =>
            {
                writer.CreateOutFile(filePath);
                return File.Exists(filePath);
            })());

            writer.WriteToOutFile(testText);
            Assert.AreEqual(testText, File.ReadAllText(filePath));

            Console.Write("Test complete!");
        }
    }
}
