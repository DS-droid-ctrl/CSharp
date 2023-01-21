Console.Clear();
Console.WriteLine("Введите число: ");
int decimalNumber = int.Parse(Console.ReadLine());
int remainder;
string result = string.Empty;
while (decimalNumber > 0)
{
    remainder = decimalNumber % 2;
    decimalNumber /= 2;
    result = remainder.ToString() + result;
}
Console.WriteLine(result);

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string accumulator = "";

while (number > 0)
{
    accumulator += number % 2;
    number /= 2;
}
   
 
Console.Write(accumulator);
*/