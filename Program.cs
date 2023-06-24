using System.Linq.Expressions;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;


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
    bool Input = true;

    while (Input)
    {

        Console.WriteLine("Оберіть завдання (1-7):");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
        case 1:
               
                string text1 = "Користувач вводить з клавіатури число від 1 до 100.  Якщо число кратне 3 (ділиться на 3 без залишку), потрібно вивести слово Fizz. Якщо число кратне 5, потрібно вивести слово Buzz. Якщо число кратне 3 і 5, потрібно вивести FizzBuzz. Якщо число не кратне ні 3, ані 5, потрібно вивести  тільки число. Якщо користувач ввів значення не в діапазоні від 1 до 100, потрібно вивести повідомлення про помилку.";
                int Width1 = 2;
                int padding1 = (Width1 - text1.Length)/2;
                string centeredText1 = text1.PadLeft(text1.Length + padding1).PadRight(Width1);
               
                Console.WriteLine(centeredText1);

              
        
        Console.WriteLine();
        Console.WriteLine("Введіть число від 1 до 100: ");
        double n = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 100)
        {

            if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            if (n % 3 == 0 && n % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }
            if (n % 5 == 0 && n % 3 != 0)
            {
                Console.WriteLine("Buzz");
            }
            if (n % 5 != 0 && n % 3 != 0)
            {
                Console.WriteLine(n);
            }
        }
        else
        {
            Console.WriteLine("Error!");
        }
        Console.WriteLine();

        break;
        
            case 2:
                string text2 = "Користувач вводить з клавіатури два числа. Перше  число — це значення, друге число - відсоток, який необхідно підрахувати. Наприклад, ми ввели з клавіатури 90 і 10. Потрібно вивести на екран 10 відсотків від 90. Результат: 9.";
              int Width2 = 2;
                int padding2 = (Width2 - text2.Length) / 2;
                string centeredText2 = text2.PadLeft(text2.Length + padding2).PadRight(Width2);

                Console.WriteLine(centeredText2);
                Console.WriteLine();

                Console.WriteLine("Введіть число №1: ");
               double A = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть число №2: ");
                double B = int.Parse(Console.ReadLine());

                double result = A * (B / 100);
                Console.WriteLine(result);

                break;

        case 3:
                string text3 = "Користувач вводить з клавіатури чотири цифри. Необхідно створити число, яке містить ці цифри. Наприклад, якщо з клавіатури введено 1, 5, 7, 8 тоді потрібно сформувати число 1578.";
                int Width3 = 2;
                int padding3 = (Width3 - text3.Length) / 2;
                string centeredText3 = text3.PadLeft(text3.Length + padding3).PadRight(Width3);

                Console.WriteLine(centeredText3);
                Console.WriteLine();

                Console.WriteLine("Введіть число №1: ");
                string ? a = Console.ReadLine();
                Console.WriteLine("Введіть число №2: ");
                string ? b = Console.ReadLine();
                Console.WriteLine("Введіть число №3: ");
                string ? c = Console.ReadLine();
                Console.WriteLine("Введіть число №3: ");
                string ? d = Console.ReadLine();

                Console.WriteLine("Число: " + a + b + c + d); 
             
              
                Console.WriteLine();
            break;
        case 4:
                string text4 = "Користувач вводить шестизначне число. Потім, користувач вводить номери розрядів для заміни цифр. Наприклад, якщо користувач ввів 1 і 6 — це означає, що треба поміняти місцями першу та шосту цифри. Число 723895 має перетворитися на 523897. Якщо користувач ввів не шестизначне число, потрібно вивести повідомлення про помилку.";
                int Width4 = 2;
                int padding4 = (Width4 - text4.Length) / 2;
                string centeredText4 = text4.PadLeft(text4.Length + padding4).PadRight(Width4);

                Console.WriteLine(centeredText4);
                Console.WriteLine();

                Console.WriteLine("Введіть число шестизначне число: ");
                string? six = Console.ReadLine();
                if (six.Length != 6 || !int.TryParse(six, out int number))
                {
                    Console.WriteLine("Помилка! Введіть коректне шестизначне число.");
                    return;
                }

                Console.Write("Введіть номер першого розряду для заміни: ");

                if (!int.TryParse(Console.ReadLine(), out int position1) || position1 < 1 || position1 > 6)
                {
                    Console.WriteLine("Помилка! Введіть коректний номер першого розряду");
                    return;
                }

                Console.Write("Введіть номер другого розряду для заміни: ");
                if (!int.TryParse(Console.ReadLine(), out int position2) || position2 < 1 || position2 > 6)
                {
                    Console.WriteLine("Помилка! Введіть коректний номер другого розряду (1-6).");
                    return;
                }
                char[] numberArray = six.ToCharArray();
               
                char temp = numberArray[position1 - 1];
                
                numberArray[position1 - 1] = numberArray[position2 - 1];
               
                numberArray[position2 - 1] = temp;
                string result6 = new string(numberArray);

                Console.WriteLine("Результат: " + result6);

                break;
        case 5:
                string text5 = "Користувач вводить з клавіатури дату. Додаток має відобразити назву пори року і дня тижня. Наприклад, якщо введено 22.12.2021, додаток має відобразити Winter Wednesday.";
                int Width5 = 2;
                int padding5 = (Width5 - text5.Length) / 2;
                string centeredText5 = text5.PadLeft(text5.Length + padding5).PadRight(Width5);

                Console.WriteLine(centeredText5);
                Console.WriteLine();

                Console.Write("Введіть дату (dd.MM.yyyy): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    string season = GetSeason(date);
                    string dayOfWeek = date.ToString("dddd");
                    Console.WriteLine(season + " " + dayOfWeek);
                }
                else
                {
                    Console.WriteLine("Помилка! Введіть коректну дату.");
                }
        

        static string GetSeason(DateTime date)
        {
            int month = date.Month;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Autumn";
                default:
                    return "Invalid";
            }
        }

        break;

        case 6:
                string text6 = "Користувач вводить з клавіатури показання температури. Залежно від вибору користувача, додаток конвертує температуру з Фаренгейта в Цельсій, або навпаки.";
                int Width6 = 2;
                int padding6 = (Width6 - text6.Length) / 2;
                string centeredText6 = text6.PadLeft(text6.Length + padding6).PadRight(Width6);

                Console.WriteLine(centeredText6);
                Console.WriteLine();

                Console.WriteLine("Введіть значення температури:");
                double temperature = double.Parse(Console.ReadLine());

                Console.WriteLine("Виберіть дію:");
                Console.WriteLine("1 - Конвертувати з Фаренгейта в Цельсій");
                Console.WriteLine("2 - Конвертувати з Цельсія в Фаренгейт");

                int choice = int.Parse(Console.ReadLine());

                double convertedTemperature = 0.0;

                switch (choice)
                {
                    case 1:
                        convertedTemperature = FToC(temperature);
                        Console.WriteLine($"Температура у Цельсіях: {convertedTemperature} °C");
                        break;
                    case 2:
                        convertedTemperature = CToF(temperature);
                        Console.WriteLine($"Температура у Фаренгейтах: {convertedTemperature} °F");
                        break;
                    default:
                        Console.WriteLine("Невірний вибір.");
                        break;
                }
        

        static double FToC(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CToF(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    

    break;
        case 7:
                string text7 = "Користувач вводить з клавіатури два числа. Потрібно показати усі парні числа у вказаному діапазоні. Якщо межі діапазону вказані неправильно, потрібно провести нормалізацію кордонів. Наприклад, користувач ввів 20 і 11. Потрібна нормалізація, після якої початок діапазону дорівнюватиме 11, а кінець дорівнюватиме 20.";
                int Width7 = 2;
                int padding7 = (Width7 - text7.Length) / 2;
                string centeredText7 = text7.PadLeft(text7.Length + padding7).PadRight(Width7);

                Console.WriteLine(centeredText7);
                Console.WriteLine();

                Console.WriteLine("Введіть число №1: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть число №2: ");
                int y = int.Parse(Console.ReadLine());

                int start = Math.Min(x, y);
                int end = Math.Max(x, y);

                Console.WriteLine("Парні числа у діапазоні від " + start + "до" + end + " : ");
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(); 

                break;
        default:

            Console.WriteLine("Помилка");
            Console.WriteLine();
            break;

        }
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
