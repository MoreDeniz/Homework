// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetArrayOfRealNumbers()
{
    Console.Write("Input size of array: ");
    int size = int.Parse(Console.ReadLine() ?? "0");

    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
        Console.Write($"{array[i]}  ");
    }
    return array;
}

double FindDiffMaxMinElems(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue) minValue = array[i];
        if (array[i] > maxValue) maxValue = array[i];
    }

    Console.WriteLine();
    
    double diff = maxValue - minValue;
    Console.WriteLine($"{maxValue} - {minValue} = {diff}");
    return diff;
}

FindDiffMaxMinElems(GetArrayOfRealNumbers());
Console.WriteLine();