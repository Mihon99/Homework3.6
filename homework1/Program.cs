int[] array = GetArray("Введите массив чисел: ");
int count = Сomparison(array);

Console.WriteLine("Чисел больше нуля в массиве = " + count);

int[] GetArray(string message)
{
    Console.WriteLine(message);
    string getArray = Console.ReadLine();
    string[] array = getArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] inputArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        inputArray[i] = int.Parse(array[i]);
    }
    return inputArray;
}

int Сomparison(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}