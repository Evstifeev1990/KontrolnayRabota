
//медот заполнения массива
string[] FillArray()
{
    Console.Write("Введите длину массива: ");
    string imputNamber = Console.ReadLine() ?? "";
    int lengthArray = int.Parse(imputNamber);
    int i = 0;
    string[] outArray = new string[lengthArray];

    while (i < lengthArray)
    {
        Console.WriteLine("Введите " + i + "-й элемент массива");
        string imputString = Console.ReadLine() ?? "";
        outArray[i] = imputString;
        i++;
    }
    return outArray;
}

//медот вывода массива на экран
void PrintArray(string[] outArray)
{
    int i = 0;
    while (i < outArray.Length)
    {
        if (outArray[i].Length<=3)
        {
            Console.Write(outArray[i] + " ");    
        }
        i++;
    }
}

string[] array = FillArray();
PrintArray(array);
