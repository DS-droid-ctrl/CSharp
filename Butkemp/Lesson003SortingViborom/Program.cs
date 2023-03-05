// СОРТИРОВКА ВЫБОРОМ
Console.Clear();

void FillArray(int[] array) // функция заполнения массива
{
    int size = array.Length; ; // определяем длину массива
    int index = 0;
    while (index < size)
    {
        array[index] = new Random().Next(1, 10); // обращение к аргументу collection с индексом и заполнение его случайным числом от 1 до 10
        index++;
    }
}
int[] array = new int[10];
FillArray(array);
int size = array.Length;
// Console.Write($" " + array);

void PrintArray(int[] array) // метод отборажения элементов массива
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($" " + array[position]);
        position++;
    }
}
PrintArray(array);
Console.WriteLine();

void SortArray(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        //поиск минимального числа
        int min = i;
        for (int j = i + 1; j < size; j++)
        {
            if (array[j] < array[min])
            {
                min = j;
            }
        }
        //обмен элементов
        int temp = array[min];
        array[min] = array[i];
        array[i] = temp;
        Console.Write($" " + array[i]);
    }
}
SortArray(array);