using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PankovaAA.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] numbers = text.Split(' ');

            double minNumber = 999999;

            foreach (string numStr in numbers)
            {
                if (numStr == "") continue;
                double num = Convert.ToDouble(numStr.Replace(".", ","));

                if (num > 0 && num % 5 == 0 && num < minNumber)
                {
                    minNumber = num;
                }
            }

            return Math.Round(minNumber, 3);
        }
            }
        }

    

