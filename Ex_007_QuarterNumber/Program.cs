//3. Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();

int QuarterNumber(int number)
{
    if (number == 1)
    {
        Console.Write("range: X > 0 , Y > 0 for number: ");
    }
    else if (number == 2)
    {
        Console.Write("range: X < 0 , Y > 0 for number: ");
    }
    else if (number == 3)
    {
        Console.Write("range: X < 0 , Y < 0 for number: ");
    }
    else if (number == 4)
    {
        Console.Write("range: X > 0 , Y < 0 for number: ");
    }
    else
    {
        Console.Write("You entered wrong number: ");
    }
    return number;
}

Console.Write("Enter number from 1 to 4: ");
Console.WriteLine(QuarterNumber(int.Parse(Console.ReadLine() ?? "0")));
