// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

int SumFor(int n, int m)
{
 int result = 0;
 for (int i = n; i <= m; i++) result += i;
 for (int i = m; i <= n; i++) result += i;
 return result;
}

Console.WriteLine(SumFor(n, m));
