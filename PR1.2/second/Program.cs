namespace second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Count_5000 = 0; int Count_2000 = 0; int Count_1000 = 0; int Count_500 = 0; int Count_200 = 0; int Count_100 = 0;
            Console.WriteLine("Введите сумму для снятия: ");
            string input_string = Console.ReadLine();
            if (int.TryParse(input_string, out int balance))
            {
                if (balance > 150000)
                {
                    Console.WriteLine("Слишком большая сумма, не смогу выдать больше 150_000");
                }
                else if (balance % 100 != 0)
                {
                    Console.WriteLine("Сумма должна быть кратна 100 ");
                }
                else if (balance <= 0)
                {
                    Console.WriteLine("Сумма не может быть отрицательной или равняться нулю");
                }
                else
                {
                    Count_5000 += balance / 5000;
                    balance = balance % 5000;

                    Count_2000 += balance / 2000;
                    balance = balance % 2000;

                    Count_1000 += balance / 1000;
                    balance = balance % 1000;

                    Count_500 += balance / 500;
                    balance = balance % 500;

                    Count_200 += balance / 200;
                    balance = balance % 200;

                    Count_100 += balance / 100;
                    balance = balance % 100;
                    if (Count_5000 != 0)
                    {
                        Console.WriteLine(Convert.ToString(Count_5000) + " по 5000");
                    }
                    if (Count_2000 != 0)
                    {
                        Console.WriteLine(Convert.ToString(Count_2000) + " по 2000");
                    }
                    if (Count_1000 != 0)
                    {
                        Console.WriteLine(Convert.ToString(Count_1000) + " по 1000");
                    }
                    if (Count_500 != 0)
                    {
                        Console.WriteLine(Convert.ToString(Count_500) + " по 500");
                    }
                    if (Count_200 != 0)
                    {
                        Console.WriteLine(Convert.ToString(Count_200) + " по 200");
                    }
                    if (Count_100 != 0)
                    {
                        Console.WriteLine(Convert.ToString(Count_100) + " по 100");
                    }
                }
            }
            else
            {
                Console.WriteLine("Должно быть целое число");
            }
        }
    }
}
