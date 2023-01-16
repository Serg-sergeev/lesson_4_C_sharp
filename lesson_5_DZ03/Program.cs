// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetRandomArray(int length = 10, int minValue = -100, int maxValue = 100)
{
    Random rnd = new Random();
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("Сгенерированный масив: " + String.Join(" ", array));
}


PrintArray(GetRandomArray());