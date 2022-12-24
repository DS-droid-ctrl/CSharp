/* Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.*/
Console.Clear();
int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int a1 = a / 10;
Console.Write($"{a1%10}");