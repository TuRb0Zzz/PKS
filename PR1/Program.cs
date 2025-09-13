using System.Linq.Expressions;

namespace calc
{
    internal class Program
    {
        static void printInfo() => Console.WriteLine("Выберите операцию из списка +, -, *, /,%, 1/x, x^2, sqrt, M+, M-, MR, clear, exit");
        private static double memory = 0;
        static void Main(string[] args)
        {
            bool isRunning = true;
            double buffer_number;
            Console.Write("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            while (isRunning)
            {
                printInfo();
                string? operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.Write("Введите число: ");
                        buffer_number = Convert.ToDouble(Console.ReadLine());
                        number = number + buffer_number;
                        break;
                    case "-":
                        Console.Write("Введите число: ");
                        buffer_number = Convert.ToDouble(Console.ReadLine());
                        number = number - buffer_number;
                        break;
                    case "*":
                        Console.Write("Введите число: ");
                        buffer_number = Convert.ToDouble(Console.ReadLine());
                        number = number * buffer_number;
                        break;
                    case "/":
                        Console.Write("Введите число: ");
                        buffer_number = Convert.ToDouble(Console.ReadLine());
                        if (buffer_number != 0)
                        {
                            number = number / buffer_number;
                        }
                        else
                        {
                            Console.WriteLine("Нельзя делить на 0");
                        }
                        break;
                    case "%":
                        Console.Write("Введите число: ");
                        buffer_number = Convert.ToDouble(Console.ReadLine());
                        if (buffer_number != 0)
                        {
                            number = number % buffer_number;
                        }
                        else
                        {
                            Console.WriteLine("Нельзя делить на 0");
                        }
                        break;
                    case "1/x":
                        if (number != 0)
                        {
                            number = 1 / number;
                        }
                        else
                        {
                            Console.WriteLine("Нельзя делить на 0");
                        }
                        break;
                    case "x^2":
                        number = number * number;
                        break;
                    case "sqrt":
                        if (number >= 0)
                        {
                            number = Math.Sqrt(number);
                        }
                        else
                        {
                            Console.WriteLine("Не могу взять корень из отрицательного числа");
                        }
                        break;
                    case "M+":
                        memory += number;
                        break;
                    case "M-":
                        memory -= number;
                        break;
                    case "MR":
                        Console.WriteLine($"Число в памяти - {memory}");
                        break;
                    case "clear":
                        Console.Write("Введите новое число: ");
                        number = Convert.ToDouble(Console.ReadLine());
                        break;
                    default:
                        isRunning = false;
                        break;
                }
                Console.WriteLine($"Текущее число {number}");
            }
        }
    }
}