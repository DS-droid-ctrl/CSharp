// Создание и заполнение массива случайными числами

Console.Clear();
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// Показать массив

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


// Создание и заполнение массива c запрашиванием данных у пользователя

// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num, min, max);
ShowArray(myRandomArray);
Console.WriteLine("-------");
// int[] myArray = CreateArray();
// ShowArray(myArray);
