// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
int a = new Random().Next(1, 1000000);
Console.WriteLine(a);
string b = a.ToString();
int n = b.Length;
if (n > 2)
{
    Console.WriteLine(b[2]);
}
else
{
    Console.WriteLine($"третьей цифры нет");
}