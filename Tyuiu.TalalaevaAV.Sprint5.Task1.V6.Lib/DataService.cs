﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.TalalaevaAV.Sprint5.Task1.V6.Lib
{
    public class DataService : ISprint5Task1V6
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempPath();
            string path_new = Path.Combine(path, "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path_new);
            bool fileExists= fileInfo.Exists;

            if (fileExists) 
            {
                File.Delete(path);
            }
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++) 
            {
                y = Math.Round((Math.Cos(x)+(4*x)/2-Math.Sin(x)*3*x), 2);
                strY= Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path_new, strY + Environment.NewLine);
                }
                else 
                {
                    File.AppendAllText(path_new, strY);
                }
            }
            return path_new;
        }
    }
}
