using System.IO;
using Tyuiu.TalalaevaAV.Sprint5.Task1.V6.Lib;
namespace Tyuiu.TalalaevaAV.Sprint5.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\79044\source\repos\Tyuiu.TalalaevaAV.Sprint5\Tyuiu.TalalaevaAV.Sprint5.Task1.V6\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}