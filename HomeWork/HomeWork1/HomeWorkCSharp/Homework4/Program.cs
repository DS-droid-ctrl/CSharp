Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (i <= n)
{
    Console.Write(i + ", ");
    i += 2;    
}