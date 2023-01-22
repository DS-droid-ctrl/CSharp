// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


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

int num = 6;
int minimum = -100;
int maxsimum = 999;

int[] myRandomArray = CreateRandomArray(num, minimum, maxsimum);
Console.WriteLine($" [ {String.Join(", ", myRandomArray)} ] ");

int min = myRandomArray[0];
for (int i = 1; i < myRandomArray.Length;)
{
    if (min > myRandomArray[i])
    {
        min = myRandomArray[i];
    }
    i++;
}
Console.WriteLine($" Минимальное число равно: {min}");

int max = myRandomArray[0];
for (int i = 1; i < myRandomArray.Length;)
{
    if (max < myRandomArray[i])
    {
        max = myRandomArray[i];
    }
    i++;
}
Console.WriteLine($" Максимальное число равно: {max}");

// Про мин и макс можно дыло написать
/*int GetDiff(int[] array)
{
    int min = array[0];
    int max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}
*/

int resalt = max - min;
Console.WriteLine($" Разница между максимальным и минимальным числом составляет: {resalt}");



// генерируем и запоняем


// Random Rand = new Random();
// double[ ] ms = new double[maxLenght];
// for (int i = 0; i < ms.Length; i++) ms[ i ] = Rand.NextDouble();
// foreach (double d in ms) Console.WriteLine(d);
// Console.ReadKey(true);
// }

/*
double [] DoubleMass (int size) // Функция задания массива случайных вещественных чисел от -100 до 100 размером size;
{
    double [] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Convert.ToDouble(new Random().Next(-1000, 1000)/10.0);
    }
    return result;    
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/