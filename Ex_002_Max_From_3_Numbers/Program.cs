//Нахождения максимального числа из трёх введённых
Console.Clear();
Console.Write("Введите первое число: ");
int numb_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numb_2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numb_3 = int.Parse(Console.ReadLine());
int max = numb_1;

if (numb_2 > max)
{
    max = numb_2;
}
if (numb_3 > max)
{
    max = numb_3;
}
    Console.WriteLine($"Максимум: число {max}");

