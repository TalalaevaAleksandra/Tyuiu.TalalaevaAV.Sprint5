using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TalalaevaAV.Sprint5.Task2.V9.Lib
{
    public class DataService : ISprint5Task2V9
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.GetTempPath();
            string path_new = Path.Combine(path, "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path_new);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path_new);
            }
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < colums; j++) 
                {
                    if (j != colums - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else 
                    {
                        str = str + matrix[i, j];
                    }
                }
                if (i != rows - 1)
                {
                    File.AppendAllText(path_new, str + Environment.NewLine);
                }
                else 
                {
                    File.AppendAllText(path_new, str);
                }
                str = "";
            }
            return path_new;
        }
    }
}
