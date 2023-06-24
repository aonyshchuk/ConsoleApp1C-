using System.Linq.Expressions;
using System.Text;
using static System.Console; 

namespace ConsoleApp1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* Користувач з клавіатури вводить довжину лінії, символ 
                заповнювач, напрямок лінії (горизонтальна, вертикальна). 
                Програма відображає лінію по заданих параметрах. 
                Наприклад: +++++.
                    Параметри лінії: горизонтальна лінія, довжина дорівнює п'яти, символ заповнювач +.*/
            try
            {
                Console.InputEncoding = Encoding.Unicode; 
                Console.OutputEncoding = Encoding.Unicode;

                Console.WriteLine("Введіть довжину лінії:");
                int length = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть символ-заповнювач:");
                char Char = char.Parse(Console.ReadLine());

                Console.WriteLine("Введіть напрямок лінії (h - горизонтальна,v - вертикальна):");
                char direction = char.Parse(Console.ReadLine());

                if (direction == 'h')
                {
                    DrawHorizontalLine(length, Char);
                }
                else if (direction == 'v')
                {
                    DrawVerticalLine(length, Char);
                }
                else
                {
                    Console.WriteLine("Неправильний напрямок лінії");
                }
                static void DrawHorizontalLine(int length, char Char)
                {
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write(Char);
                    }
                    Console.WriteLine();
                }

                static void DrawVerticalLine(int length, char Char)
                {
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine(Char);
                    }
                }


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