// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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

// int count = 0;
// for (int i = 0; i < myRandomArray.Length; i++) {
//     if (myRandomArray[i] >=10 && myRandomArray[i] < 100) count++;
// };
// Console.WriteLine(count);
