Console.Clear();
string[] arrayString = { "hello", "2", "world", ":-)" };

Console.Write($"Введенный массив: [ {string.Join(" ", arrayString)} ]");
Console.WriteLine();

string[] newString = FindElementsLessThenValue(arrayString);

string[] FindElementsLessThenValue(string[] array)
{
    string[] newArray = new string[array.Length];
    int value = 3;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= value)
        {
            newArray[j] = array[i];
            j++;
        }
        else
            j = j * 1;
    }
    return newArray;
}

string[] PrintArray(string[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] != null) count++;
    }

    int j = 0;
    string[] resultArray = new string[count];
    for (int i = 0; i < count; i++)
    {
        resultArray[j] = inputArray[i];
        j++;
    }
    return resultArray;
}
Console.WriteLine();
Console.Write($"Получившийся массив: [ {String.Join(" ", PrintArray(newString))} ]");
