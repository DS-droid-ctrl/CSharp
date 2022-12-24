Console.Clear();
Console.WriteLine("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

    int a = x1 - x2;

    int b = y1 - y2;

    if (a < 0)
    {
        a *= -1;
    }

    if (b < 0)
    {
        b *= -1;
    }

double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
Console.WriteLine($"Расстояние между точками равно: {d}");