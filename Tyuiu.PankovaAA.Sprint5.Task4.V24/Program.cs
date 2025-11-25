using Tyuiu.PankovaAA.Sprint5.Task4.V24.Lib;
namespace Tyuiu.PankovaAA.Sprint5.Task4.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V24.txt";

            Console.Title = "Спринт #5 [Выполнила: Панькова А.А.] ПИН6-25-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема:  Чтение данных из текстового файла                                   *");
            Console.WriteLine("* Задание #04                                                                *");
            Console.WriteLine("* Вариант #24                                                                *");
            Console.WriteLine("* Выполнила: Панькова Ангелина Алексеевна | ПИН6-25-1                        *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("*******************************************************************************");


            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("*******************************************************************************");
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(@"C:\DataSprint5\");
                File.WriteAllText(path, "2.0");
            }


            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат: " + res);
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}