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
