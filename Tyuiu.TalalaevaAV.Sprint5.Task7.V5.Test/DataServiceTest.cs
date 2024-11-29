using System.IO;
using Tyuiu.TalalaevaAV.Sprint5.Task7.V5.Lib;
namespace Tyuiu.TalalaevaAV.Sprint5.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path1 = @"C:\Users\79044\AppData\Local\Temp\OutPutFileTask7.txt";
            FileInfo fileInfo = new FileInfo(path1);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}