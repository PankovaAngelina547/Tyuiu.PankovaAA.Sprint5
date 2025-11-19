using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;

namespace Tyuiu.PankovaAA.Sprint5.Task0.V18.Lib
{
    public class DataService: ISprint5Task0V18
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double z = x / Math.Sqrt(x * x + x);
            z = Math.Round(z, 3); 
            File.WriteAllText(path, z.ToString());
            return path;
        }
    }
}