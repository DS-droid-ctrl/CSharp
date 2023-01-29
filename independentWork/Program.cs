Console.Clear();
static void formatString()
{
    //Console.OutputEncoding = Encoding.UTF8;
    double money = 12.8;
    //Console.WriteLine(money.ToString("C2"));
    Console.WriteLine($"{money:C2}");
}

static void sravnenieString()
{
    // string str1 = "abcde";
    // string str2 = "abcde";

    // bool areEqual = str1 == str2;
    // Console.WriteLine(areEqual);

    // bool areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
    // Console.WriteLine(areEqual);
}

// Console.WriteLine("Hi, please tell me your name");

// string name = Console.ReadLine();
// string sentence = $"Your name is {name}";
// Console.WriteLine(sentence);

// Console.WriteLine("Hi, please tell me your age");
// string input = Console.ReadLine();
// int age = int.Parse(input);
// // int.Parse(input) преобразовывает строку в число

// string sentence = $"Your age is {age}";
// Console.WriteLine(sentence);

static void FormatColor()
{
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("New Style ");
    Console.Write("New Style\n"); // \n это тоже самое, что WriteLine
}

// РЕКУРСИЯ

static void FactorialNumbers()
{
    Console.Clear();
    int factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * factorial(n - 1);
        }
    }
    // Console.WriteLine("Введите число, факториал которого хотите найти: ");
    // int n = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(factorial(n));

    Console.WriteLine(factorial(5));
}

static void BeskonechayaRekursiya()
{/*
    // бесконечная рекурсия, печатающая 1
    void rec(int x)
    {
        Console.WriteLine(x);
        rec(x);
    }
    rec(1);

    // бесконечная рекурсия с подсчетом строк
    void rec(int x)
    {
        Console.WriteLine(x);
        rec(x + 1); // подсчет количества строк
    }
    rec(1);

    // ОБРАТНЫЙ ОТСЧЕТ
    void rec(int x)
    {
        if (x < 4)
        {
            // Console.WriteLine(x);
            rec(x + 1);
            Console.WriteLine(x);
        }

    }
    rec(1);*/
}

static void ChisloFibonacci()
{
    Console.Clear();
    int fibonacci(int n)
    {
        if (n == 1)
        {
            return 0;
        }
        if (n == 2)
        {
            return 1;
        }
        else
        {
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
    // Console.WriteLine("Введите число, факториал которого хотите найти: ");
    // int n = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(fibonacci(n));

    Console.WriteLine(fibonacci(5));
}

void polindrom (string s = "шалаш")
{
    if (s.Length <= 1)
    {
        Console.WriteLine("Полиндром");
    }
    if (s[0] != s[s.Length-1])
    {
        Console.WriteLine("Не полиндром");
    }
    else
    {
        return polindrom(s[s.Length-s.Length+1; s.Length-1])
    }    
}

