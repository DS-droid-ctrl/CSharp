Console.Clear(); // чистка консоли
// Console.SetCursorPosition(10, 4); // определение места расположения точки на экране (10 интервалов слева и 4 межстрочных расстояний сверху)
// Console.WriteLine("+"); // точка будет отображаться в виде +

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb;

int count = 0;

while(count < 10000) // пока count меньше 10 выполняем
{
    int what = new Random().Next(0, 3); // вводим переменную what со случайными значениями от 0 до 3 (0, 1, 2)
    if(what == 0) // пока what равно 0
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(what == 1) // пока what равно 1
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2) // пока what равно 2
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // или count +=1 или count++
}