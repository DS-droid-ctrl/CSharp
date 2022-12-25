Console.Clear();

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;
if (b > max)
{
    max = b;
    min = a;
}

Console.WriteLine($"Наибольшее число {max}");
Console.Write($"Наименьшее число {min}");
