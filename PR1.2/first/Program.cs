namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели, с которого начинается месяц (1-пн .. 7-вс): ");
            int start_day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер дня месяца: ");
            int day_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----Проверяем выходной ли день----");
            if ((day_number>=1 && day_number<= 5) || (day_number>=8 && day_number<=10)){
                Console.WriteLine("Выходной");
            }
            else
            {
                int count_day = (start_day + (day_number % 7) - 1)%7;
                if (count_day > 5)
                {
                    Console.WriteLine("Выходной");
                }
                else
                {
                    Console.WriteLine("Рабочий");
                }
            }
        }
    }
}
