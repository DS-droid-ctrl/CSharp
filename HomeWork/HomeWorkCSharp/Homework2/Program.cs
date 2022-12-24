Console.Clear();

int Max(int a, int b, int c)
{
    int result = a;
    if (b > result) result = b;
    if (c > result) result = c;
    return result;
}
int a = 2;
int b = 3;
int c = 7;

int max1 = Max(a, b, c);
Console.WriteLine($"Наибольшим числом из {a}, {b} и {c} является: {max1}");

a = 44;
b = 5;
c = 78;

int max2 = Max(a, b, c);
Console.WriteLine($"Наибольшим числом из {a}, {b} и {c} является: {max2}");

a = 22;
b = 3;
c = 9;

int max3 = Max(a, b, c);
Console.WriteLine($"Наибольшим числом из {a}, {b} и {c} является: {max3}");