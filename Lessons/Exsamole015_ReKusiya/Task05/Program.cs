// Найти a в стпени n

// Императивный метод
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

// Рекурсия
int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
    // или одной строкой return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 3));
Console.WriteLine(PowerRec(2, 3));

