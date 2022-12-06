namespace if3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которой  пользователь  вводит с клавиатуры чилсо. 
             * Если числов либо равно 5 либо равно 10, то программа выводит "Число равно 5, либо равно 10". 
             * Иначе программа выводит сообщение "Неизвестное число"
             */

            int num;

            Console.WriteLine("Введите число: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 5 || num == 10)
            {
                Console.WriteLine("Число равно 5, либо равно 10.");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
            Console.ReadKey();
        }
    }
}