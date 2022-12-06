namespace if4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличатся.
             * Напишите программу, в которую прользователь вводит сумму вклада. Если сумма вклада
             * меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%.
             * Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить
             * сумму вклада с начисленными процентами.
             */

            double money;

            Console.WriteLine("Введите сумму вклада: ");
            money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"ваша сумма: {money}");

            if(money <= 100 && money > 0)
            {
                Console.WriteLine($"Сумма Вашего вклада {money + (money / 100  * 5)} с процентами. 5% составили {money / 100 * 5}! ");
            }
            else if(money > 100 && money <= 200)
            {
                Console.WriteLine($"Сумма Вашего вклада {money + (money / 100 * 7)} с процентами. 5% составили {money / 100 * 7}! ");
            }
            else if(money > 200)
            {
                Console.WriteLine($"Сумма Вашего вклада {money + (money / 100 * 10 )} с процентами. 5% составили {money / 100 * 10}! ");
            }
            else if(money < 0)
            {
                Console.WriteLine($"У Вас нет денег и Ваш долг составляет {money + ( money / 100 * 10) } с процентами. 5% составили {money / 100 * 10}! ");
            }
            else 
            {
                Console.WriteLine(" У Вас нет денег!");
            }
            Console.ReadLine();
        }
    }
}