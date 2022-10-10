string[] TransformArray(string[] masStr)
{
    int newLength = 0;
    for (int k = 0; k < masStr.Length; k++)
    {
        if (masStr[k].Length < 4) newLength++;
    }
    string[] newMasStr = new string[newLength];
    int i = 0;
    int j = 0;
    while (j < newLength)
    {
        if (masStr[i].Length < 4)
        {
            newMasStr[j] = masStr[i];
            j++;
        }
        i++;
    }
    return newMasStr;
}
void PrintArray(string[] arr)
{
    if (arr.Length == 0)
    {
        Console.Write("[]");
    }
    else
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write($"\"{arr[i]}\", ");
        }
        Console.Write($"\"{arr[arr.Length - 1]}\"]");
    }
}
try
{
    string[] array = {"hello", "2", "world", ":-)"}; 
    //string[] array = {"1234", "1567", "-2", "computer science"}; 
    //string[] array = { "Russia", "Denmark", "Kazan" };
    PrintArray(array);
    Console.Write($" -> ");
    PrintArray(TransformArray(array));
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}