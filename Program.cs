using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using static System.Console;

/*Користувач вводить з клавіатури п'ять чисел. Необхідно знайти суму чисел, максимум і мінімум з п'яти чисел, 
добуток чисел. Результат обчислень вивести на екран.*/
namespace ConsoleApp1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode; 
            Console.OutputEncoding = Encoding.Unicode;

            try
            { 

                Write("Введіть число 1: "); 
                int number1 = Convert.ToInt32(Console.ReadLine()); 
                Write("Введіть число 2: "); 
                int number2 = Convert.ToInt32(Console.ReadLine());
                Write("Введіть число 3: ");
                int number3 = Convert.ToInt32(Console.ReadLine());
                Write("Введіть число 4: ");
                int number4 = Convert.ToInt32(Console.ReadLine());
                Write("Введіть число 5: ");
                int number5 = Convert.ToInt32(Console.ReadLine());


                WriteLine($"Сума: {number1 + number2 + number3 + number4 + number5}");
                WriteLine($"Добуток: {number1 * number2 * number3 * number4 * number5}");
                WriteLine($"Максимальне число: {Math.Max(Math.Max(Math.Max(Math.Max(number1, number2), number3), number4), number5)}");
                WriteLine($"Мінімальне число: {Math.Min(Math.Min(Math.Min(Math.Min(number1, number2), number3), number4), number5)}");

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally {
                Console.ReadKey(); 
            }

        }
    }
}