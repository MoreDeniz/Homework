//Сравнение двух чисел
Console.Clear();
Console.Write("Введите первое число: ");
int numb_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numb_2 = int.Parse(Console.ReadLine());

if (numb_1 > numb_2)
{
    Console.WriteLine($"Число  {numb_1} больше числа {numb_2}");
}
if (numb_2 > numb_1)
{
    Console.WriteLine($"Число  {numb_2} больше числа {numb_1}");
}
else if (numb_2 == numb_1)
{
    Console.WriteLine($"Число  {numb_2} равно числу {numb_1}");
}
