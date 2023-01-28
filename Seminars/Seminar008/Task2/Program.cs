// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива
Console.Clear();
int[,] matrix = new int[5, 5];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
ChangeRow(matrix);
PrintArray(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
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
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void ChangeRow(int[,] matr)
{
    int temp = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        temp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0)-1, i];
        matr[matr.GetLength(0)-1, i] = temp;
    }
}
