// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[] GetArrayRandom (int length)
{
    int[] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
    return arr;
}

void ShowArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
}

int[] array = GetArrayRandom(8);
ShowArray(array);

// В качестве ограничений вбил сотни, так как иначе алгоритм выдаёт только положительные числа с большим количеством цифр, а в задании числа максимально двухразрядные.