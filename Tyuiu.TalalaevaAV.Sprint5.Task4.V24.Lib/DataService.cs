using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TalalaevaAV.Sprint5.Task4.V24.Lib
{
    public class DataService : ISprint5Task4V24
    {
        public double LoadFromDataFile(string path)
        {
            string x;
            double res;
            x = File.ReadAllText(path).Replace(".", ",");
            res = Convert.ToDouble(x);
            double f= Math.Round(((Math.Pow(Convert.ToDouble(res), -2)+2)*Math.Sin(Convert.ToDouble(res))), 3);
            return f;
        }
    }
}
