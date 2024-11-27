using System.IO;
using Tyuiu.TalalaevaAV.Sprint5.Task3.V24.Lib;
namespace Tyuiu.TalalaevaAV.Sprint5.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\79044\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}