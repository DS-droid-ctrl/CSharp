Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a%7 == 0) & (a%23 == 0))
{
    Console.Write($"Число {a} является кратным 7 и 23");
}
else 
    Console.Write($"Число {a} не является кратным 7 и 23");