// Math.Abs (); модуль числа
// Функция - подпрограмма, выполняющая какие-либо операции и возвращающая значение.
// Процедура - подпрограмма, которая только выполняет операции, без возврата значения.
// Метод - это функция или процедура, которая принадлежит классу или экземпляру класса.
// Math.Pow(number, degree) - возведение в квадрат
// Math.Sqrt(numer, degree) квадратный корень
// Math.Sqrt(16, 2) квадратный корень из 16


Console.Clear();
Console.Write("Введите X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
if (x1 > 0 && y1 > 0)
{
    Console.Write("1 четверть");
}
else if (x1 > 0 && y1 < 0)
{
    Console.Write("2 четверть");
}
else if (x1 < 0 && y1 < 0)
{
    Console.Write("3 четверть");
}
else if (x1 < 0 && y1 > 0)
{
    Console.Write("4 четверть");
}
else 
{
    Console.Write("не существует");
}
