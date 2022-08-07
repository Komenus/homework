Console.Clear();
Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB) 
{
    Console.WriteLine("Наибольшее число ");
    Console.WriteLine(numberA);
    Console.WriteLine("Наименьшее число ");
    Console.WriteLine(numberB);
    }
else
{
   Console.WriteLine("Наибольшее число ");
    Console.WriteLine(numberB);
    Console.WriteLine("Наименьшее число ");
    Console.WriteLine(numberA);
}