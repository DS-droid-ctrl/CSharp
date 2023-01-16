// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
float[] CreateRandomArray(int N, float start, float end)
{
    float[] RandomArray = new float[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().NextFloat(start, end + 1);
    }
    return RandomArray;
}

int num = 6;
int min = -100;
int max = 999;

float[] myRandomArray = CreateRandomArray(num, min, max);
Console.WriteLine($" [ {String.Join("| ", myRandomArray)} ] ");

// генерируем и запоняем

// const int maxLenght = 50;
// static void Main()
// {
// Random Rand = new Random();
// double[ ] ms = new double[maxLenght];
// for (int i = 0; i < ms.Length; i++) ms[ i ] = Rand.NextDouble();
// foreach (double d in ms) Console.WriteLine(d);
// Console.ReadKey(true);
// }