Console.Write("Введите массив чисел: ");
string getArray = Console.ReadLine();
string[] array = getArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] inputArray = new int[array.Length];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    inputArray[i] = int.Parse(array[i]);
}

for (int i = 0; i < array.Length; i++)
{
    if (inputArray[i] > 0)
    {
        count++;
    }
}

Console.WriteLine("Чисел больше нуля в массиве = " + count);