/*
1. Cортировка пузырьком (базовая)
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/

Console.Clear();

static void sortingBable()
{
    Console.WriteLine("Введите кол-во элементов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите значения массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
    Console.WriteLine();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
        Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
    }
}

static void sortingBableBase()
{
    int[] array = new int[10];

void FillArray(int[] collection) // функция заполнения массива
{
    int length = collection.Length; // определяем длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // обращение к аргументу collection с индексом и заполнение его случайным числом от 1 до 10
        index++;
    }
}

void PrintArray(int[] col) // метод отборажения элементов массива
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($" " + array[position]);
        position++;
    }
}

static int[] SortgBable(int[] array)
{
    int size = array.Length;

    for (int current = 0; current < size; current++)
    {
        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }            
        }
    }
    return array;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
SortgBable(array);
PrintArray(array);
}


// 2. Сортировка методом пузырька (оптимизированная)

