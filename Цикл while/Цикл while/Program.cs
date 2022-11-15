// See https://aka.ms/new-console-template for more information
// пишем программу покторая поздравит нас столько раз сколько нам лет
int age; // My it's old.
age = Convert.ToInt32(Console.ReadLine());

while(age-- > 0) // the decrement can be set in the condition
{
    
    if (age == 5)
    {
        continue;// right
    }
    Console.WriteLine("Привет");
}
Console.ReadKey();
