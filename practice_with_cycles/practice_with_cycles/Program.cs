namespace practice_with_cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа.
            * А программа сарвнивает два введённых числа и выводит на консоль результат сравнения
            * (два числа равны, первое число больше второго или первое число меньше второго).
            */

            int num1;
            int num2;

            Console.WriteLine("Ведите первое число: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите второе число");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"Первое число {num1} больше второго {num2}. ");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Первое число {num1} меньше второго {num2}. ");
            }
            else
            {
                Console.WriteLine($"Чилсо {num1} и {num2} равны. ");
            }
            
        }
    }
}