// See https://aka.ms/new-console-template for more information
string [] GetStringArray()
{
    Console.WriteLine("Введите массив строк в одну строку, элементы через запятую:");
    string str = Console.ReadLine();
    string [] strArray = str.Split(',');
    return strArray;
}

string [] CreateNewArray(string [] initArray)
{
    string newStringArray = string.Empty;
    for (int i = 0; i < initArray.Length; i++)
    {
        if (initArray[i].Length<=3)
        {
            newStringArray += initArray[i] + ",";
        }
    }
    string [] array = newStringArray.Split(',', StringSplitOptions.RemoveEmptyEntries);
    return array;
}
void PrintArray(string[] arr)
{
    for (int i =0; i< arr.Length;i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

string [] stringArray = GetStringArray();
string [] result = CreateNewArray(stringArray);
PrintArray(result);
