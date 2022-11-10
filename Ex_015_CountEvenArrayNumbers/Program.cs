// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetThreeDigitNumbersArray()
{
    Console.Write("Input size of array: ");
    int size = int.Parse(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int CountEvenElements(int[] array)
{
    int count = 0;
    Console.WriteLine();

    foreach (int el in array)
    {
        if (el % 2 == 0) count++;
    }
    Console.WriteLine($"There are {count} even numbers in this array.");
    return count;
}

CountEvenElements(GetThreeDigitNumbersArray());
Console.WriteLine();

