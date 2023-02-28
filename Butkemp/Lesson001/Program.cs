// Дано число N. Показать числа от -N до N

// void KakNeNadoReshat()
// {
//     int n = 5;

// for (int i = -n; i <= n; i++)
// {
//     Console.WriteLine(i);
// }
// }
// KakNeNadoReshat();


// Способ 1 с фукцией (как можно)
// void PrintNumbers1(int n)
// {
//     for (int i = -n; i <= n; i++)
//     {
//         Console.WriteLine(i);
//     }
// }
// int n = 5;
// PrintNumbers1(n);


// Улучшение кода
// void PrintNumbers1(int n)
// {
//     for (int i = -n; i <= n; i++)
//     {
//         Console.Write(i + " ");
//     }    
// }
// int n = 5;
// PrintNumbers1(n);


// С вводом от пользователя
// int GetValueByUser(string text)
// {
//     Console.Write(text);
//     return int.Parse(Console.ReadLine()!);
// }

// void PrintNumbers1(int n)
// {
//     for (int i = -n; i <= n; i++)
//     {
//         Console.Write(i + " ");
//     }
// }
// int n = GetValueByUser("Введите N ");
// PrintNumbers1(n);


// С ограничением по числу (защита от дурака)
// int GetValueByUser(string text)
// {
//     int value = 0;
//     bool flag = false;
//     do
//     {
//         Console.Write(text);
//         string s = Console.ReadLine()!;
//         flag = int.TryParse(s, out value) && value > 0;
//     } while (!flag);
//     return value;
// }

// void PrintNumbers1(int n)
// {
//     for (int i = -n; i <= n; i++)
//     {
//         Console.Write(i + " ");
//     }
// }
// int n = GetValueByUser("Введите N ");
// PrintNumbers1(n);


// Убираем печать в консоль для возможности печати в файл
// int GetValueByUser(string text)
// {
//     int value = 0;
//     bool flag = false;
//     do
//     {
//         Console.Write(text);
//         string s = Console.ReadLine()!;
//         flag = int.TryParse(s, out value) && value > 0;
//     } while (!flag);
//     return value;
// }

// string PrintNumbers2(int n)
// {
//     string output = String.Empty;

//     for (int i = -n; i <= n; i++)
//     {
//         // output = output + i + " ");
//         output = output + $"{i} ";
//     }
//     return output;
// }
// int n = GetValueByUser("Введите N ");

// string res = PrintNumbers2(n);
// Console.WriteLine(res);
// File.WriteAllText("data.txt", res);


// Третий способ улучшенный (берем цикл от 0) для того, чтобы сократить операции в 2 раза
// int GetValueByUser(string text)
// {
//     int value = 0;
//     bool flag = false;
//     do
//     {
//         Console.Write(text);
//         string s = Console.ReadLine()!;
//         flag = int.TryParse(s, out value) && value > 0;
//     } while (!flag);
//     return value;
// }

// string PrintNumbers3(int n)
// {
//     string output = "0 "; // чтобы 0 отображался в середине

//     for (int i = 1; i <= n; i++)
//     {
//         output = $"{-i} " + output + $"{i} ";
//     }
//     return output;
// }
// int n = GetValueByUser("Введите N ");

// string res = PrintNumbers3(n);
// Console.WriteLine(res);
//File.WriteAllText("data.txt", res);



// ВТОРАЯ ЗАДАЧА. Посчитать сколько в массиве чисел можно найти по три цифры (подмассив)
// int [] GetRangeSum1(int[] array, int m) // array - массив, m - подмассив
// {
//     int n = array.Length; // n = количеству элементов в массиве
//     int[] t = new int[n - m + 1]; // n - m + 1 формула по которой вычисляется количество подмассива в массиве

//     int index = 0; // index для записи количества подмассивов

//     for (int i = 0; i <= n - m; i++)
//     {
//         for (int j = i; j < i + m; j++)
//         {
//             t[index] += array[j];
//         }
//         index++;
//     }
//     return t;
// }

// int[] CreateArray(int size) => new int[size]; // создание массива

// string Print(int[] array) => $"[{String.Join(", ", array)}]"; // печать массива

// void Fill(ref int[] array) => array = array.Select(e => Random.Shared.Next(10)).ToArray(); // заполнение массива числами от 0 до 10, ref нужен чтобы показать что массив будет меняться

// int[] numbers = CreateArray(5); 
// Fill(ref numbers); // запись массива в numbers
// Console.WriteLine(Print(numbers)); // печать массива

// int count = 2; // счетчик
// int[] sumGroupNumbers = GetRangeSum(numbers, count);
// Console.WriteLine(Print(sumGroupNumbers));

// Улучшение 1 (сзади из подмассива убираем цифру, спереди прибавляем)
// int[] GetRangeSum2(int[] array, int m) // array - массив, m - подмассив
// {
//     int n = array.Length;
//     int[] t = new int[n - m + 1];
//     int sum = 0;
//     for (int i = 0; i < m; i++) sum += array[i];
//     int index = 0;
//     t[index++] = sum;

//     for (int i = 1; i <= n - m; i++)
//     {
//         sum = sum - array[i - 1] + array[i + m - 1];
//         t[index++] = sum;
//     }
//     return t;
// }

// int[] CreateArray(int size) => new int[size]; // создание массива

// string Print(int[] array) => $"[{String.Join(", ", array)}]"; // печать массива

// void Fill(ref int[] array) => array = array.Select(e => Random.Shared.Next(10)).ToArray(); // заполнение массива числами от 0 до 10, ref нужен чтобы показать что массив будет меняться

// int[] numbers = CreateArray(5);
// Fill(ref numbers); // запись массива в numbers
// Console.WriteLine(Print(numbers)); // печать массива

// int count = 2; // счетчик
// int[] sumGroupNumbers = GetRangeSum2(numbers, count);
// Console.WriteLine(Print(sumGroupNumbers));

// Улучшение 2
int[] GetRangeSum2(int[] array, int m) // array - массив, m - подмассив
{
    int n = array.Length;
    int[] t = new int[n - m + 1];

    int index = 0;
    for (int i = 0; i < m; i++) t[index] += array[i];

    for (int i = 1; i <= n - m; i++)
    {
        index++;
        t[index] = t[index - 1] - array[i - 1] + array[i + m - 1];
    }
    return t;
}

int[] CreateArray(int size) => new int[size]; // создание массива

string Print(int[] array) => $"[{String.Join(", ", array)}]"; // печать массива

void Fill(ref int[] array) => array = array.Select(e => Random.Shared.Next(10)).ToArray(); // заполнение массива числами от 0 до 10, ref нужен чтобы показать что массив будет меняться

int[] numbers = CreateArray(5);
Fill(ref numbers); // запись массива в numbers
Console.WriteLine(Print(numbers)); // печать массива

int count = 2; // счетчик
int[] sumGroupNumbers = GetRangeSum2(numbers, count);
Console.WriteLine(Print(sumGroupNumbers));