void PrintArray(int[,] matr)
    {
        for (int i = 0; i < 3; i++)  // или for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < 4; j++) // или for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} "); // выводим в одну строку
            }
            Console.WriteLine(); // пустая строка между выводимыми между таблицами
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
