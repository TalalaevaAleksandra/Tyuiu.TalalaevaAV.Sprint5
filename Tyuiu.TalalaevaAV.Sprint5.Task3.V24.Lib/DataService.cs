using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TalalaevaAV.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempPath();
            string path_new = Path.Combine(path, "OutPutFileTask3.bin");
            double y = 6.1 * Math.Pow(x, 3) + 0.23*Math.Pow(x,2) + 1.04 * x;
            y = Math.Pow(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path_new, FileMode.OpenOrCreate), Encoding.UTF8)) 
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path_new;
        }
    }
}
