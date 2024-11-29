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

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Собираем строку через StringBuilder
                    var filteredLine = new System.Text.StringBuilder();
                    for (int i = 0; i < line.Length; i++)
                    {
                        // Проверяем, если символ разрешён
                        if ((line[i] != 'H') && (line[i] != 'e') && (line[i] != 'l') && (line[i] != 'o') &&
                            (line[i] != 'I') && (line[i] != 'F') && (line[i] != 's') && (line[i] != 'M') &&
                            (line[i] != 'y') && (line[i] != 'i') && (line[i] != 'r') && (line[i] != 'P') &&
                            (line[i] != 'g') && (line[i] != 'a') && (line[i] != 'm') && (line[i] != 't'))
                        {
                            // Убираем лишние пробелы: добавляем пробел, только если последний символ не пробел
                            if (!(line[i] == ' ' && (filteredLine.Length > 0 && filteredLine[^1] == ' ')))
                            {
                                filteredLine.Append(line[i]);
                            }
                        }
                    }

                    // Убираем пробелы по краям строки перед записью
                    var finalLine = filteredLine.ToString().Trim();

                    char[] charArray = finalLine.ToCharArray(); // Преобразуем строку в массив символов

                    if (charArray.Length >= 11)
                    {
                        charArray[10] = '\0'; // Удаляем 10-й элемент (заменяем на '\0' для удаления)
                    }

                    // Собираем строку обратно, пропуская '\0'
                    string result = new string(charArray).Replace("\0", "").Trim();


                    // Записываем в файл
                    if (!string.IsNullOrEmpty(result))
                    {
                        File.AppendAllText(path_new, result + Environment.NewLine);
                    }
                }
            }

            return path_new;
        }
    }
}
