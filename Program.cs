using System.Linq.Expressions;
using System.Text;
using static System.Console;

/* Виведіть на екран цитату Б'ярна Страуструпа: It's easy 
to win forgiveness for being wrong; being right is what gets you 
into real trouble.
 */
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
               ForegroundColor = ConsoleColor.DarkMagenta;
               WriteLine("It's easy to win forgiveness for being wrong;");
               WriteLine("being right is what gets you \r\ninto real trouble.");
               ForegroundColor = ConsoleColor.Magenta;
               WriteLine("Bjarne Stroustrup");
               Read(); 
            }

            catch (Exception e)
            {
              WriteLine(e.Message);

            }
            finally {
                ReadKey(); 
            }

        }
    }
}