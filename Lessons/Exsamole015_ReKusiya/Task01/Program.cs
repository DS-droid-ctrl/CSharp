// РЕКУРСИЯ
// Рекурсия - это функция, вызывающая сама себя
// Условия выхода
// Задача собрать строку с числами от а до b, a<=b

string NumbersFor(int a, int b) // императивный метод
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b) // рекурсия
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));