// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] GetArray()
{
    Console.Write("Input size of array: ");
    int size = int.Parse(Console.ReadLine());
    Console.Write("Input lower limit of array: ");
    int minValue = int.Parse(Console.ReadLine());
    Console.Write("Input upper limit of array: ");
    int maxValue = int.Parse(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int SumOddElemsOfArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Sum of odd array elements = {sum}");
    return sum;
}

SumOddElemsOfArray(GetArray());