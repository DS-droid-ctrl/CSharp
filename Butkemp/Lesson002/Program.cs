// Создаем и заполняем массив

/*int[] array = new int[5];
for (int i = 0; i < 5; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(" ", array) + "]");
Console.WriteLine(array[3]);*/

// Сложность алгоритма О(1) или онатация
// Если необходимо найти сумму элементов массива из 5 чисел, то нам понабится 5 операций,
// Если количество элементов n, сложность операции будет О(n)
// Если массив отсортированный, то О(n * log n)
// ((5 + 1)/2) * 5 - O(1) - арифмитическая прогрессия (первый элемент + последний элемент) / 2 * количество элементов

// О(n2) n в квадрате
// Таблица умножения
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write(i * j);  
//         Console.Write("\t"); // табуляция для отступов в таблице
//     }
//     Console.WriteLine();
// }

// Уменьшаем количество операций
int n = Convert.ToInt32(Console.ReadLine());
int[, ] matrix = new int[n, n]; // Создаем матрицу
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
// О(n2 / 2)