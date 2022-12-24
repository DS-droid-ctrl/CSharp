Console.Clear();
int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int a1 = a / 100;
int a2 = a % 10;
Console.WriteLine($"{a1}{a2}");

// или Console.Write($"{a/100}{a%10}");
// или int b = (num1 % 100) % 10;
