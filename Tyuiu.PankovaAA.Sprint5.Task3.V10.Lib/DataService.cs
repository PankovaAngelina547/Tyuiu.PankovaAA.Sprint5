using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PankovaAA.Sprint5.Task3.V10.Lib
{
    public class DataService : ISprint5Task3V10
    {
        public string SaveToFileTextData(int x)
        {
            double result = CalculateFunction(x);

            
            double roundedResult = Math.Round(result, 3);

            
            string path = SaveToBinaryFile(roundedResult);

            return path;
        }

        private double CalculateFunction(int x)
        {
            
            double term1 = -Math.Pow(x, 3);      
            double term2 = 4 * Math.Pow(x, 2);   
            double term3 = (3.0 / 2.0) * x;      

            return term1 + term2 - term3;
        }

        private string SaveToBinaryFile(double data)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(data);
            }

            return path;
        }
    }
}
           
        
