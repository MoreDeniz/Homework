// Вывод всех чётных чисел от 1 до введённого
Console.Clear();
Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());
int even = 2;

if (numb < even)
{
    Console.WriteLine($"Таких чисел нет");
}
else
    while (even <= numb)
    {
        Console.Write($"{even}; ");
        even += 2;
    }
Console.WriteLine();
