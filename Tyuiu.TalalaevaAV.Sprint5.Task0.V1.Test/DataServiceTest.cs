using System.IO;
using Tyuiu.TalalaevaAV.Sprint5.Task0.V1.Lib;

namespace Tyuiu.TalalaevaAV.Sprint5.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\79044\source\repos\Tyuiu.TalalaevaAV.Sprint5\Tyuiu.TalalaevaAV.Sprint5.Task0.V1\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists= fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}