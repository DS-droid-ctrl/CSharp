int [] Array = CreateRandomArray(123, -10, 123);
ShowArray(Array);
int count = 0;

 for (int i = 0; i< Array.Length; i++)
{
    if (Array[i]>=10 && Array[i]<=99)
    {
        count = count +1;
    }
}

Console.WriteLine($"В массиве ровно {count} чисел в диапазоне между 10 и 99");