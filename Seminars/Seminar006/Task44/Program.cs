Console.WriteLine($"Введите количество чисел Фибоначчи");
int val_1 = Convert.ToInt32(Console.ReadLine());

int param_1 = 0;
int param_2 = 1;
int temp = param_2;

temp = param_1 + param_2; //1
Console.WriteLine(param_1); //0
Console.WriteLine(param_2); // 1

for (int i = 0; i < val_1; i++)
{
    temp = temp + param_2; // 2
    param_1 = param_2;
    param_2 = temp - param_1;

    Console.WriteLine(temp);
    
}