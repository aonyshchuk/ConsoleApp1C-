using System.Linq.Expressions;
using System.Text;
using static System.Console;

/*
 Користувач з клавіатури вводить шестизначне число. 
Необхідно перевернути число і відобразити результат. 
Наприклад, якщо введено 341256, результат 652143.
 */

namespace ConsoleApp1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputEncoding = Encoding.Unicode;
            OutputEncoding = Encoding.Unicode;

            Write("Введіть число: ");
            string? str = Console.ReadLine();
            WriteLine($"Результат: {str = new string(str.Reverse().ToArray())}");

        }
    }
} 