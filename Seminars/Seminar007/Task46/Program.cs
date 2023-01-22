// Матрица случайных чисел
Console.Clear();

int [,] matrix = new int[4,4];
FillArray(matrix);
Console.WriteLine("Задача 48.");
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Задача 49.");
FillArraySqr(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Задача 51.");
FillArrayDiag(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = i + j;
        }
    }
}

void FillArraySqr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matr[i,j] = matr[i,j] * matr[i,j];
        }
    }
}

void FillArrayDiag(int[,] matr)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) count += matr[i,j];
        }
    }

    Console.WriteLine($"Сумма чисел диагонали: {count}");
}