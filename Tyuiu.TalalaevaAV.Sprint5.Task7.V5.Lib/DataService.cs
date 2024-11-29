using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5; 
namespace Tyuiu.TalalaevaAV.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            string path1 = Path.GetTempPath();
            string path_new = Path.Combine(path1, "OutPutFileTask7.txt");
            FileInfo fileInfo = new FileInfo(path_new);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path_new);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    for (int i = 0; i < line.Length; i++) 
                    {
                        if ((line[i]!='H') && (line[i]!='e')&& (line[i] != 'l') && (line[i] != 'o') && (line[i] != 'I') && (line[i] != 'F') && (line[i] != 's') && (line[i] != 'm') && (line[i] != 'y') &&(line[i] != 'i') && (line[i] != 'r') && (line[i] != 'p') && (line[i] != 'g') && (line[i] != 'a') && (line[i] != 'm')) 
                        {
                            strLine += line[i];
                        }
                    }
                    File.AppendAllText(path_new, strLine+ Environment.NewLine);
                    strLine = "";
                }
            }
            return path_new;
        }
    }
}
