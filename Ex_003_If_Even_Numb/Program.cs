// Проверка числа на чётность
Console.Clear();
Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());

if (numb == 0)
{
    Console.WriteLine($"Это число 0");
}
else if (numb % 2 != 0)
{
    Console.WriteLine($"Число {numb} нечётное");
}
else
{
    Console.WriteLine($"Число {numb} чётное");
}


