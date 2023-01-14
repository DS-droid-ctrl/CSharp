// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

// Console.Clear();
// Console.Write("Введите число A: ");
// int A = int.Parse(Console.ReadLine());
// int x = 1; // с нулем не получается

// for (int i = 1; i <= A; i++)
// {
//     x *= i;
// }
// Console.Write(x);



Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");


int GetMultiply(int number)
{
    int result = 1;
    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }
    return result;
}


Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int c = GetCountNums(num);
Console.WriteLine($"Количество цифр = {c}");

// Console.WriteLine($"Количество цифр = {GetCountNums(16)}");


int GetCountNums(int number)
{
    int count = 0;
    while(number>0)
    {
        count++;
        number/=10;
    }
    return count;
}


Console.WriteLine("Введите число: ");
string a = Convert.ToString(Console.ReadLine());
int i = Convert.ToInt32(a.Length);

Console.WriteLine($"В числе {a} ровно {i} цифр");




// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int [] boolNum = new int [8];

// for (int i=0; i < 8; i++){
//     boolNum[i] = new Random().Next(0, 2);
//     Console.Write(boolNum[i]);
// }


// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

int[] array = GetBinaryArray(8);
Console.WriteLine($" [ {String.Join(" // ", array)} ] ");


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }

    return result;
}
