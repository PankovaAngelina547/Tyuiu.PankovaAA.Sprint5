using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PankovaAA.Sprint5.Task1.V16.Lib
{
    public class DataService : ISprint5Task1V16
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double y = CalculateFunction(x);
                    string result = y.ToString("F2", CultureInfo.InvariantCulture); 

                    if (x < stopValue)
                    {
                        writer.WriteLine(result);
                    }
                    else
                    {
                        writer.Write(result);
                    }
                }
            }

            return path;
        }

        private double CalculateFunction(int x)
        {
            try
            {
                double term1 = Math.Sin(x);
                double term2 = (2.0 * x) / 3.0;
                double term3 = Math.Cos(x) * 4 * x;

                return Math.Round(term1 + term2 - term3, 2);
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }
    }
}