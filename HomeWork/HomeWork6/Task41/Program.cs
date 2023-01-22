// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число D: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число E: ");
int e = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int[] array = {a, b, c, d, e};
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum++;
    }
}
Console.Write($"Введено чисел больше 0: {sum}");