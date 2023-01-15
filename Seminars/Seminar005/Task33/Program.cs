// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Clear();
Write("Введите элементы массива через пробел: ");
string elements = ReadLine();
int[] baseArray = GetArrayFromString(elements);
Write("Введите число: ");
int n = int.Parse(ReadLine());
if (FindElement(baseArray, n))
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}


int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

bool FindElement(int[] array, int el)
{
    foreach (var item in array)
    {
        if (el == item) return true;
    }
    return false;
}
