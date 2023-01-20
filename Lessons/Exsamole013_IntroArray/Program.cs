// ЛЕКЦИЯ 4 Рекурсия и двумерные массивы
// string[,] table = new string[2, 3]; // создание строк и столбцов
// int[,] matrix = new int[5,8]; // прямоугольная таблица  5 строк 8 столбцов
// String.Empty

Console.Clear();

static void formatString() // Строки и столбцы string двумерный массив
{
    string[,] table = new string[2, 5];
    // заполнение строк и столбцов
    table[1, 2] = "слово"; // первая сторока, второй столбец

    for (int rows = 0; rows < 2; rows++)
    {
        for (int colums = 0; colums < 5; colums++)
        {
            Console.WriteLine($"-{table[rows, colums]}-");
        }
    }
}

static void formatString2() // Строки и столбцы int двумерный массив
{
    int[,] matrix = new int[3, 4];

    for (int i = 0; i < 3; i++)  // или for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < 4; j++) // или for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} "); // выводим в одну строку
        }
        Console.WriteLine(); // пустая строка между выводимыми строками
    }
}

static void twoArray() // создание двумерного массива, его заполнение и вывод на экран
{
    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < 3; i++)  // или for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < 4; j++) // или for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} "); // выводим в одну строку
            }
            Console.WriteLine(); // пустая строка между выводимыми строками
        }
    }

    void FillArray(int[,] matr) // функция заполнения двумерного массива числами
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);
            }
        }
    }

    int[,] matrix = new int[3, 4];
    PrintArray(matrix);
    FillArray(matrix);
    Console.WriteLine();
    PrintArray(matrix);
}

static void Array() // функция закрашивания области внутри заданного объекта
{
    int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

    void PrintImage(int[,] image)
    {
        for (int i = 0; i < image.GetLength(0); i++)
        {
            for (int j = 0; j < image.GetLength(1); j++) // или for (int j = 0; j < image.GetLength(1); j++)
            {
                // Console.Write($"{image[i, j]} "); // выводим в одну строку
                if (image[i, j] == 0) Console.Write($" ");
                else Console.Write($"+");
            }
            Console.WriteLine(); // пустая строка между выводимыми строками
        }
    }

    void FillImage(int row, int col) // функция закрашивания массива
    {
        if (pic[row, col] == 0) // задаем местоположение первоначальной точки
        {
            pic[row, col] = 1; // закрашивать будем единицами
            FillImage(row - 1, col);
            FillImage(row, col - 1);
            FillImage(row + 1, col);
            FillImage(row, col + 1);
        }
    }

    PrintImage(pic);
    FillImage(13, 13);   // координаты начальной точки в нашем массиве
    PrintImage(pic);
}

static void Factorial() // Факториал числа
{
    // Факториал числа
    // ! это факториал в математике

int Factorial(int n)
{
    // 1! = 1 факториал из 1 будет 1
    // 0! = 1 факториал из 0 будет 1
    if (n == 1) return 1;
    else return n* Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
}

// Чило Фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}