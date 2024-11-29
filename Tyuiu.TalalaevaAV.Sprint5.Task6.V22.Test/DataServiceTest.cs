using System.IO;
using Tyuiu.TalalaevaAV.Sprint5.Task6.V22.Lib;
namespace Tyuiu.TalalaevaAV.Sprint5.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V22.txt";
            var res =ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait,res);
        }
        [TestMethod]
        public void TestMethod2() 
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

        }
    }
}