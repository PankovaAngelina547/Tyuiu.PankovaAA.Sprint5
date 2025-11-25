using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PankovaAA.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            {
                string text = File.ReadAllText(path).ToLower();
                int count = 0;

                for (int i = 0; i < text.Length - 1; i++)
                {
                    if (text[i] == 'с' && text[i + 1] == 'с')
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
        
