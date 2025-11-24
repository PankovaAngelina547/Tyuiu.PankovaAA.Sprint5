using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PankovaAA.Sprint5.V18.Lib
{
    public class DataService : ISprint5Task0V18
    {
        public string SaveToFileTextData(int x)
        {
            double y = x / Math.Sqrt(x * x + x);
            string result = Math.Round(y, 3).ToString("F3");
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(path, result);

            return path;
        }
    }
}
