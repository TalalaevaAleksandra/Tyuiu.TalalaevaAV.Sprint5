using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TalalaevaAV.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл по пути {path} не найден.");
            }

            // Список для хранения чисел из файла
            var numbers = new List<double>();

            // Считать строки из файла
            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                // Разделить строку на элементы
                var values = line.Split(new[] { ' ', ',', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var value in values)
                {
                    // Преобразовать строку в число, если возможно
                    if (double.TryParse(value, out double num))
                    {
                        // Округлить вещественные значения до 3 знаков
                        numbers.Add(Math.Round(num, 3));
                    }
                }
            }

            // Найти максимальное простое число среди целых чисел
            int maxPrime = -1;

            foreach (var number in numbers)
            {
                if (number % 1 == 0) // Проверяем, что число целое
                {
                    int intValue = (int)number;

                    if (intValue > 1 && IsPrimeInline(intValue))
                    {
                        maxPrime = Math.Max(maxPrime, intValue);
                    }
                }
            }

            
            return maxPrime;
        }

        private bool IsPrimeInline(int number)
        {
            if (number <= 1) return false;
            if (number == 2 || number == 3) return true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
        
