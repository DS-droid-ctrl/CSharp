// See https://aka.ms/new-console-template for more information
int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    { result[i] = inArray[i]; }
    return result;
}