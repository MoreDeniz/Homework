// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();

int GetPowNums(int number, int power)
{
    int powerResult = 1;
    for (int i = 1; i <= power; i++)
    {
        powerResult *= number;
    }
    return powerResult;
}
Console.WriteLine();

Console.Write("Input natural number A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Input natural number B: ");
int numB = int.Parse(Console.ReadLine());

int rezult = GetPowNums(numA, numB);

Console.WriteLine($"Число {numA} в степени {numB} = {rezult}.");
