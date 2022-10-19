//2. По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();

int EnterNumber()    //function Enter Number
{
    Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
return num;
}

int SquareNumber(int num)   //function calculate the square of a number
{
    int square = num * num;
    return square;
}

bool IsSquare(int num1, int num2)
{
    return num1 == SquareNumber(num2);
}
int num1 = EnterNumber();
int num2= EnterNumber();

Console.WriteLine(IsSquare(num1, num2) ? $"Число {num1} квадрат числа {num2};" : $"Число {num1} не квадрат числа {num2};");
Console.WriteLine(IsSquare(num2, num1) ? $"Число {num2} квадрат числа {num1};" : $"Число {num2} не квадрат числа {num1};");