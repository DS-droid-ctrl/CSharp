/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

// Console.Clear();
// Console.WriteLine("Введите пятизначное число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// string a = b.ToString();
// int n = a.Length;
// if (n > 4 && n < 6)
// {
//     if ((a[0] == a[4]) && (a[1] == a[3]))
//     {
//         Console.WriteLine("Введенное число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Введенное число не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Введено неправильное число");
// }

// Второе решение

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 9999 && a < 100000)
{
    if ((a / 10000 == a % 10) && (a / 1000 % 10 == a / 10 % 10))
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введено неправильное число");
}