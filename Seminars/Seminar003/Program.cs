// Math.Abs (); модуль числа
// Функция - подпрограмма, выполняющая какие-либо операции и возвращающая значение.
// Процедура - подпрограмма, которая только выполняет операции, без возврата значения.
// Метод - это функция или процедура, которая принадлежит классу или экземпляру класса.

// Условия
// https://drive.google.com/file/d/1L-0DJEqvLLWJt3narSBmVOzhgjgxCfxl/view?usp=sharing

// Циклы
// https://drive.google.com/file/d/16HeFPlR_eEEVGCGykwUfTJFrnQJsnGHR/view?usp=sharing

// Массивы
// https://drive.google.com/file/d/1PurYbjxB7zBX5s1oxLmgZq7BRE2DRT5v/view?usp=sharing


// Codeforce - сайт для тренировок

// https://codeforces.com/

// https://www.videosharp.info/console/book

// https://checkio.org/

// https://leetcode.com/



// Console.Clear();
// Console.Write("Введите X: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// if (x1 > 0 && y > 0)
// {
//     Console.Write("1 четверть");
// }
// else if (x1 > 0 && y < 0)
// {
//     Console.Write("2 четверть");
// }
// else if (x1 < 0 && y < 0)
// {
//     Console.Write("3 четверть");
// }
// else if (x1 < 0 && y > 0)
// {
//     Console.Write("4 четверть");
// }
// else 
// {
//     Console.Write("не существует");
// }

// int quarter (int x1, int y1);


int quarter(int x1, int y1); // или void quarter(int x1, int y1);
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

Console.Write("Введите X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
quarter(x1, y1);