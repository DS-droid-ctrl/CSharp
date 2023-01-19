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
            matr[i,j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
