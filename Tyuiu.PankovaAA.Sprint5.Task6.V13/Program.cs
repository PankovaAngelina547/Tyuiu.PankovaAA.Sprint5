using Tyuiu.PankovaAA.Sprint5.Task6.V13.Lib;
namespace Tyuiu.PankovaAA.Sprint5.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "Спринт #5 [Выполнила: Панькова А.А.] ПИН6-25-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема:  Чтение данных из текстового файла                                   *");
            Console.WriteLine("* Задание #06                                                                *");
            Console.WriteLine("* Вариант #13                                                                *");
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
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";

            int res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}