﻿/* Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.*/
Console.Clear();
Console.Write("Введите день недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if ((a == 6) || (a == 7))
{
    Console.Write($"Выбранный Вами день недели является выходным днем");
}
else
{
    Console.Write($"Выбранный Вами день недели не является выходным днем");
}