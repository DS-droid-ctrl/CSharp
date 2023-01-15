// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

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

int num = 8;
int min = -100;
int max = 1000;

int[] myRandomArray = CreateRandomArray(num, min, max);
Console.WriteLine($" [ {String.Join(" , ", myRandomArray)} ] ");