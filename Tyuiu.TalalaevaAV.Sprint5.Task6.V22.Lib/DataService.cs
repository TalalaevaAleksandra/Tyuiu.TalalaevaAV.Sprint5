using System.IO;
using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TalalaevaAV.Sprint5.Task6.V22.Lib
{
    public class DataService : ISprint5Task6V22
    {
        public int LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);
            int count = 0;
            for (int i = 0; i < fileContent.Length - 1; i++)
            {
                if (fileContent[i] == 'м' && fileContent[i + 1] == 'м')
                {
                    count++;
                }
            }
            return count;


        }
    }
}
