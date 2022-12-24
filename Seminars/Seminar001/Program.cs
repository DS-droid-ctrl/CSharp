Console.Clear();

//Console.WriteLine("Введите число: ");

//int number = Convert.ToInt32(Console.ReadLine());
// int number = int.Parse(Console.ReadLine());

//int sqr = number * number;

//Console.Write("Квадрат числа: " + number + " равен: " + sqr);
// либо Console.Write($"Квадрат числа {number} равен: {sqr}");

//Console.WriteLine(sqr);

// либо Console.Write("Квадрат числа: " + sqr + "еще что-нибудь");


Console.Write("Введите первое число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());

if (numFirst == numSecond*numSecond)
{
    Console.Write($"Число {numFirst} является квадратом {numSecond}");
}
else 
    Console.Write($"Число {numFirst} не является квадратом {numSecond}");
