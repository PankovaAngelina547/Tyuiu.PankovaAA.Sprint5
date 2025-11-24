using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PankovaAA.Sprint5.Task2.V18.Lib
{
    public class DataService : ISprint5Task2V18
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetLength(0); 
            int columns = matrix.GetLength(1); 

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {
                    string line = "";
                    for (int j = 0; j < columns; j++)
                    {
                        
                        int value = (matrix[i, j] > 0) ? 1 : 0;

                        if (j < columns - 1)
                        {
                            line += value + "; ";
                        }
                        else
                        {
                            line += value;
                        }
                    }
                    writer.WriteLine(line);
                }
            }

            return path;
        }
    }
}


