Console.Clear();

Console.Write("Введите первое число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());

if ((numFirst == numSecond*numSecond) || (numSecond == numFirst*numFirst))
{
    Console.Write($"Одно из чисел является квадратом другого");
}
else 
    Console.Write($"Ни одно число не являются квадратом другого");
