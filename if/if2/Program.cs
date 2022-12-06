namespace if2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которую пользователь вводить с клавиатуры число. 
             * Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10".
             * Иначе программа выводит сообщение "Неизвестное число".
             */

            int num;

            Console.WriteLine("Ведите числo: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num > 5 && num < 10)
            {
                Console.WriteLine($"Число больше {num} больше 5 и меньше 10. ");
            }
            else
            {
                Console.WriteLine("Неизвестное число! ");
            }
            Console.ReadKey();
        }
    }
}