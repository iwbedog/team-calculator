using System.Globalization;
using System.Text;

namespace TeamCalculator
{
    partial class Program
    {
        static double a = 0;
        static double b = 0;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"A = {a}, B = {b}");
                Console.WriteLine("1 - ввести A");
                Console.WriteLine("2 - ввести B");
                Console.WriteLine("3 - выполнить операцию \"+\"");
                Console.WriteLine("4 - выполнить операцию \"-\"");
                Console.WriteLine("5 - выполнить операцию \"*\"");
                Console.WriteLine("6 - выполнить операцию \"/\"");
                Console.WriteLine("0 - выход");
                Console.Write("Выберите пункт меню: ");

                string? choice = Console.ReadLine();
                switch (choice?.Trim())
                {
                    case "1": InputA(); break;
                    case "2": InputB(); break;
                    case "3": Add(); break;
                    case "4": Subtract(); break;
                    case "5": Multiply(); break;
                    case "6": Divide(); break;
                    case "0":
                    case null:
                        return;
                    default:
                        Console.WriteLine("Нет такого пункта меню.");
                        break;
                }
            }
        }

        // Reads a number, accepting both "2.5" and "2,5"
        static double ReadNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? text = Console.ReadLine();
                if (text == null)
                    return 0;
                text = text.Trim().Replace(',', '.');
                if (double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                    return value;
                Console.WriteLine("Это не число, попробуйте ещё раз.");
            }
        }
    }
}
