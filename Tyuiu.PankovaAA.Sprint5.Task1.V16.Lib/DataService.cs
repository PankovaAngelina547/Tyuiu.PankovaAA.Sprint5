using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PankovaAA.Sprint5.Task1.V16.Lib
{
    public class DataService : ISprint5Task1V16
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Табулирование функции F(x) = sin(x) + 2x/3 - cos(x)*4x");
                writer.WriteLine($"Диапазон: [{startValue}; {stopValue}]");
                writer.WriteLine("x\t\tf(x)");
                writer.WriteLine("----------------------");

                for (int x = startValue; x <= stopValue; x++)
                {
                    double y = CalculateFunction(x);
                    writer.WriteLine($"{x}\t\t{y:F2}");
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

                double result = term1 + term2 - term3;
                return Math.Round(result, 2);
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }
    }
}