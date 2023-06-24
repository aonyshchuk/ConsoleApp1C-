using System.Linq.Expressions;
using System.Text;
using static System.Console;


/*
 Користувач вводить з клавіатури межі числового діапазону. Потрібно показати усі числа Фібоначчі з цього 
 діапазону. Числа Фібоначчі — елементи числової послідовності, у якій перші два числа дорівнюють 0 і 1, а кожне 
наступне число дорівнює сумі двох попередніх чисел. Наприклад, якщо вказано діапазон 0–20, результат буде: 0, 1, 1, 2, 3, 5, 8, 13.
 */
namespace ConsoleApp1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputEncoding = Encoding.Unicode; 
            OutputEncoding = Encoding.Unicode;


           

            try
            {
               WriteLine("Введіть нижню межу діапазону: ");
                int low = int.Parse(ReadLine());

                WriteLine("Введіть верхню межу діапазону: ");
                int upp = int.Parse(ReadLine());

                WriteLine("Числа Фібоначчі у вашому діапазоні:");

                
               
                for (int i = low; i <= upp; i++)
                { 
                        int[] f = new int[i + 1];
                        f[0] = 0;
                        f[1] = 1;
                        f[i] = f[i - 2] + f[i - 1];


                        WriteLine("Число Фібоначчі" + f);
                        
                 
                }
                ReadLine();
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