using Tyuiu.PankovaAA.Sprint5.V18.Lib;
namespace Tyuiu.PankovaAA.Sprint5.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;

            Console.Title = "Спринт #5 [Выполнила: Панькова А.А.] ПИН6-25-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема: Запись данных в текстовый файл                                       *");
            Console.WriteLine("* Задание #0                                                                 *");
            Console.WriteLine("* Вариант #18                                                                *");
            Console.WriteLine("* Выполнила: Панькова Ангелина Алексеевна | ПИН6-25-1                        *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить       *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.                 *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                    *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("*******************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
