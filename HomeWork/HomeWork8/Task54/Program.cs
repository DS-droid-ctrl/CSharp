// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

Console.Clear();
Console.WriteLine("Введите размер матрицы:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[a, b];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
FillArrayReplace(matrix);

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

// void FillArrayReplace(int[,] matr)
// {
//     int max = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1)-1; j++)
//         {
//             if (matrix[i, j] > matrix[i, j+1]) { max = matrix[i, j]; }
//             else { max = matrix[i, j+1]; matrix[i, j+1] = matrix[i, j]; matrix[i, j] = max;}
//             Console.WriteLine(matrix);
//         }
//         //matrix[i, j] = max;
//         //onsole.WriteLine(FillArrayReplace);
//     }
//     //Console.WriteLine(FillArrayReplace);
// }

void FillArrayReplace(int[,] matr)
{
// Console.WriteLine("---");
//сортируем
for (int i = 0; i < matrix.GetLength(0); i++)
    //сортировка пузырьком
    for (int j = 0; j < matrix.GetLength(1); j++)
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            if (matrix[i, j] <= matrix[i, k]) continue;
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, k];
            matrix[i, k] = temp;
            Console.Write(matrix[i, j]);
        }
        

// for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine())
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{0,4}", matrix[i, j]);
//     }

// FillArrayReplace(matrix);
// Console.Read();
}