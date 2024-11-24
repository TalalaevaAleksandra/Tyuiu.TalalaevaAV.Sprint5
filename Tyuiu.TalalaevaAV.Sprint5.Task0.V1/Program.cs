using Tyuiu.TalalaevaAV.Sprint5.Task0.V1.Lib;
namespace Tyuiu.TalalaevaAV.Sprint5.Task0.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнила: Талалаева А.В. | ИИПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Талалаева Александра Васильевна | ИИПБ-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение выражения                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            Console.WriteLine("x=  " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res =ds.SaveToFileTextData(x);
            Console.WriteLine("Файл "+ res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
