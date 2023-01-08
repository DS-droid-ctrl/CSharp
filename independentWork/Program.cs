Console.Clear();
static void formatString()
{
    //Console.OutputEncoding = Encoding.UTF8;
    double money = 12.8;
    //Console.WriteLine(money.ToString("C2"));
    Console.WriteLine($"{money:C2}");
}

static void sravnenieString()
{
    // string str1 = "abcde";
    // string str2 = "abcde";

    // bool areEqual = str1 == str2;
    // Console.WriteLine(areEqual);

    // bool areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
    // Console.WriteLine(areEqual);
}

// Console.WriteLine("Hi, please tell me your name");

// string name = Console.ReadLine();
// string sentence = $"Your name is {name}";
// Console.WriteLine(sentence);

// Console.WriteLine("Hi, please tell me your age");
// string input = Console.ReadLine();
// int age = int.Parse(input);
// // int.Parse(input) преобразовывает строку в число

// string sentence = $"Your age is {age}";
// Console.WriteLine(sentence);

Console.BackgroundColor = ConsoleColor.Cyan;
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("New Style ");
Console.Write("New Style\n"); // \n это тоже самое, что WriteLine
