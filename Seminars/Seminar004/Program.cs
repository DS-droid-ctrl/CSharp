// Console.Clear();
// Console.Write("Введите число A: ");
// int A = int.Parse(Console.ReadLine());
// int x = 0;

// for(int i = 1; i <= A; i++)
// {
//     x+=i;
// }
// Console.Write(x);


// Console.Clear();
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write(summa_(A));
// int summa_(int number)
// {
//     int sum=0;
//     for (int i=1;number>=i;i++)
//     {
//         sum+=i;
//     }
//     return sum;
// }

void GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += i;
    } 
    Console.WriteLine($"Cумма цифр от 1 до {Math.Abs(number)}: {sum}");
}

Console.Clear();

GetSumNums(-5);
GetSumNums(58);
GetSumNums(25);
GetSumNums(16);

Console.WriteLine("Введите число A");
int n = Convert.ToInt32(Console.ReadLine());
GetSumNums(n);

Console.WriteLine("Введите число A");
GetSumNums(Convert.ToInt32(Console.ReadLine()));
