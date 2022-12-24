Console.Clear();
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
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // поиск индекса элемента массива
{
    int count = collection.Length; // размер массива
    int index = 0;
    int position = -1; // переменная в которую будет записываться индекс после выполнения функции обычно 0, но если ищем число невходящее в масси, то будет выводится -1

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position; //возвращает позицию
}

int[] array = new int[10]; // создан массив с 10 элементами

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);