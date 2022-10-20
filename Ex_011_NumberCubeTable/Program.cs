// принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

int EnterNumber()    //function: Enter Number
{
    Console.Write("Enter number: ");
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int CubeNumber(int num)    //function: Cube Number
{
    int cube = num * num * num;
    return cube;
}

int Output(int num) //function: Output
{
    int count = 1;
    while (count <= num)
    {
        int cube = CubeNumber(count);
        Console.Write($"{cube};  ");
        count++;
    }
    return num;
}

Output(EnterNumber());

Console.WriteLine();
