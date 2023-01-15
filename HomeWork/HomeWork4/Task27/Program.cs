// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0)
{
    a *= -1;
}
int[] array = a.ToString().Select(t => int.Parse(t.ToString())).ToArray();
int sum = 0;
int size = array.Length;

for (int i = 0; i < size; i++)
{
    sum = sum + array[i];
}
Console.WriteLine($"Суммма цифр в числе: {sum}");