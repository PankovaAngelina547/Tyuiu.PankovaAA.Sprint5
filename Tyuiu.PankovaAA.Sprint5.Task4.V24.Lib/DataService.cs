using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PankovaAA.Sprint5.Task4.V24.Lib
{
    public class DataService : ISprint5Task4V24
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            text = text.Replace(".", ",");
            double x = Convert.ToDouble(text);

            double result = (1 / (x * x) + 2) * Math.Sin(x);
            return Math.Round(result, 3);

        }
    }
    
}
