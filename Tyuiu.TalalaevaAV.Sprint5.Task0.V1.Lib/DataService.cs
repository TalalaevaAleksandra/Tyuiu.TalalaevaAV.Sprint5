using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.TalalaevaAV.Sprint5.Task0.V1.Lib
{
    public class DataService : ISprint5Task0V1
    {
        public string SaveToFileTextData(int x)
        {
            string path=$@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double f = x * x * x + 2 * x * x + 5 * x + 4;
            f=Math.Round(f,3);
            string path_new = @"/app\OutPutFileTask0.txt";
            File.WriteAllText(path, Convert.ToString(f));
            return path_new;
            
            
        }
    }
}
