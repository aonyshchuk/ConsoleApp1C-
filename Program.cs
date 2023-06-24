using System.Linq.Expressions;
using System.Text;
using static System.Console; 

namespace ConsoleApp1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Дано цілі додатні числа A і B (A < B). Вивести усі цілі
            числа від A до B включно; кожне число має виводитися у
            новому рядку; при цьому кожне число має виводитися у
            кількість разів, рівну його значенню. Наприклад: якщо А
            = 3, а В = 7, то програма має сформувати в консолі такий
            висновок:
                    3 3 3
                    4 4 4 4
                    5 5 5 5 5
                    6 6 6 6 6 6
                    7 7 7 7 7 7 7
             */
            


            try
            {

            Console.InputEncoding = Encoding.Unicode; 
            Console.OutputEncoding = Encoding.Unicode;

                WriteLine("Введіть число А: ");
                int A = int.Parse(ReadLine());

                WriteLine("Введіть число В: ");
                int B = int.Parse(ReadLine());

  

                if (A < B)
                {
                    for (int i = A; i <= B; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(i + " ");

                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    WriteLine("Число А повинно бути меншим за В");
                }

                  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}