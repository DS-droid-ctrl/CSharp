// Создание трехмерного массива

// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N

Console.Clear();
// void OutputNumbers(int n, int m) 
// {
//     if (n >= m)
//     {
//         OutputNumbers(n - 1,m);
//         Console.WriteLine(n);
//     }
// }
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());




// void OutputNumbers(int n, int m)
// {
//     if (n > m)
//     {
//         OutputNumbers(n - 1, m);
//         Console.WriteLine(n);
//     }
//     else
//     {
//         if (m > n)
//         OutputNumbers(m + 1, n);
//         Console.WriteLine(m);
//     }
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());

// OutputNumbers(n, m);







// void OutputNumbers(int n, int m) 
// {

//     if (n >= m) {
//         OutputNumbers(n - 1,m);
//         Console.WriteLine(n);
//     }

// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n>m) 
// {
//     OutputNumbers(n, m);
// }
// if (m>n)
// {
//     OutputNumbers(m, n);
// }
// if (m==n)
// {
//     Console.Write("Числа равны ");
// }


// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine("Сумма цифр числа:"+Sum(num));
// int Sum(int inputNum)
// {
//     if (inputNum < 10) return inputNum;
//     else return inputNum % 10 + Sum(inputNum / 10);
// }



/* Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int B = Convert.ToInt32(Console.ReadLine());

int DegreeNum (int A, int B) {
    if (B != 1) {
        return (A * DegreeNum(A, B - 1));
    }
    return A;
}
System.Console.WriteLine(DegreeNum(A, B));



// Console.Clear();
// Console.Write("Введите число: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите степень: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine($"{Pow(m,n)}");

// int Pow(int number,int rank)
// {
//     if (rank == 0) return 1;
//     else return (number * Pow(number,rank-1));
// }
