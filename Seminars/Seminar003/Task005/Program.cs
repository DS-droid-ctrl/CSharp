void quarter(int x1, int y1) // это функция после скобки точка с запятой не ставится void значит безвозвратная. 
// Если объявить функцию int quarter(int x1, int y1) значит возвратная
{
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
}

// Console.Write("Введите X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// quarter(x, y);
// Чтобы не вводить вручную координаты можно:
// quarter(13, -2); таким образом ввести координаты или
// Далее решение с рандомными (случайными числами от -100 до 100)
int x_1 = new Random().Next(-100, 100);
Console.WriteLine(x_1 );
int y_1 = new Random().Next(-100, 100);
Console.WriteLine(y_1 );
quarter(x_1, y_1);