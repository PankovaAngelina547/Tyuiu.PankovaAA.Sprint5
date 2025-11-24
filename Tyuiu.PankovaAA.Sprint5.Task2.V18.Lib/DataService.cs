using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PankovaAA.Sprint5.Task2.V18.Lib
{
    public class DataService : ISprint5Task2V18
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < 3; i++)
                {
                    writer.Write(matrix[i, 0] > 0 ? "1" : "0");
                    writer.Write(";");
                    writer.Write(matrix[i, 1] > 0 ? "1" : "0");
                    writer.Write(";");
                    writer.Write(matrix[i, 2] > 0 ? "1" : "0");

                    if (i < 2)
                    {
                        writer.WriteLine();
                    }
                }
            }

            return path;
        }
    }
}