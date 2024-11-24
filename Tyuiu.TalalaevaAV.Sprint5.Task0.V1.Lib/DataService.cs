using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.TalalaevaAV.Sprint5.Task0.V1.Lib
{
    public class DataService : ISprint5Task0V1
    {
        public string SaveToFileTextData(int x)
        {
            double res = x * x * x + 2 * x * x + 5 * x + 4;
            res = Math.Round(res, 3);
            string path = "64";
            return path;


        }
    }
}
