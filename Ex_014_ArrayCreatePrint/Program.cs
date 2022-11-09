// Задача 29: Напишите программу, которая задаёт массив
//из 8 элементов и выводит их на экран.

Console.Clear();

void GetArray(int[] arr)    // создание массива
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);
        Console.Write($" {arr[i]};");   // проверка: какие числа созданы
    }
    Console.WriteLine();
}

void PrintArray(int[] arr)  // вывод массива
{
    Console.Write($"[");
    int size = arr.Length;
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
    Console.Write($"{arr[size - 1]}]");
    Console.WriteLine();
}

int[] arr = new int[8];
GetArray(arr);
PrintArray(arr);