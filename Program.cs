using System.Linq.Expressions;
using System.Text;
using static System.Console; 

namespace ConsoleApp1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode; 
            Console.OutputEncoding = Encoding.Unicode;


            //Console.SetCursorPosition(50, 10); //Встановлення позиції курсора
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.WriteLine("Hello C#!");
            //Console.SetCursorPosition(50, 11);
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Error!");
            //Console.SetCursorPosition(50, 12);
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Warnings!");
            //Console.SetCursorPosition(50, 13);
            //Console.WriteLine("Увага!");
            //Console.ResetColor();
            //Console.Read(); //Затримка консолі

            try
            {


                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть рядок: ");
                string? str = Console.ReadLine(); //str = значення або 0
                                                  //Console.WriteLine("Text: " + str);
                                                  //Console.WriteLine("Text: {0}", str);
                Console.WriteLine($"Text: {str}");

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