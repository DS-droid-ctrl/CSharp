//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Clear();
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B < 0)
{
    B *= -1;
}
if (B == 0)
{
    Console.WriteLine($"Результат равен 1");
}

int result = 0;
for (int i = 0, temp = 1; i <= B; temp *=A)
{
    i++;
    result = temp;
}
Console.WriteLine($"Чило {A} в степени {B} равно {result}");


// Решение без цикла
// Console.Clear();
// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// if (B < 0)
// {
//     B *= -1;
// }
// if (B == 0)
// {
//     Console.WriteLine($"Результат равен 1");
// }

// double d = Math.Pow(A, B);
// Console.WriteLine($"Чило {A} в степени {B} равно {d}");