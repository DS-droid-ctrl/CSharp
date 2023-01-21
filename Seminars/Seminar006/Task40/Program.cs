Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < b + c)
{
    Console.WriteLine("Такой треугольник существует");
}
else
{
    Console.WriteLine("Такой треугольник не существует");
}

/*
РЕШЕНИЕ С ПОМОЩЬЮ МАССИВА

int[] CreateRandomArray(int N, int start, int end){
   
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

int[] CreateArray(){
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void checkTriangle(int [] array){

    if( array[0] < array[1]+array[2] && 
        array[1] < array[0]+array[2] &&
        array[2] < array[0]+array[1])
        Console.WriteLine("Такой триугольник существует");
    else
        Console.WriteLine("Такой триугольник не существует");

}

int [] array = CreateArray();
checkTriangle(array);
*/