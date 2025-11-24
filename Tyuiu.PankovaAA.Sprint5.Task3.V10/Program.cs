using Tyuiu.PankovaAA.Sprint5.Task3.V10.Lib;
namespace Tyuiu.PankovaAA.Sprint5.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 4;

            Console.Title = "Спринт #5 [Выполнила: Панькова А.А.] ПИН6-25-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема:  Потоковый метод записи в бинарный файл                              *");
            Console.WriteLine("* Задание #03                                                                *");
            Console.WriteLine("* Вариант #10                                                                *");
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

            Console.WriteLine("x = " + x);


            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("*******************************************************************************");

            double result = -Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - (3.0 / 2.0) * x;
            double roundedResult = Math.Round(result, 3);
            Console.WriteLine($"F({x}) = {roundedResult:F3}");

            
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}