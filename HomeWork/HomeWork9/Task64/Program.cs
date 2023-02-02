// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{n}. ");

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine(NumbersFor(n, 1));



// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// while (n >= 1)
// {
//     Console.Write($"{n} ");
//     n--;
// }
