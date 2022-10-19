//4. Найти расстояние между точками в пространстве 2D
Console.Clear();

double EnterNumber()    //function: Enter Coordinates
{
    Console.Write("Enter coordinate: ");
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}

double Diff(double num1, double num2)   //function: difference of two numbers
{
    double diff = num2 - num1;
    return diff;
}

double Sum2(double num1, double num2)   //function: sum of 2 numbers
{
    double sum = num1 + num2;
    return sum;
}

double SquareNumber(double num)   //function: square of a number
{
    double square = num * num;
    return square;
}

double DistanceBetweenPoints(double num)   //function: Square Root of a number
{
    double distance = Math.Sqrt(num);
    return distance;
}

Console.WriteLine("Enter coordinates X, Y of the First Point:");
double x1 = EnterNumber();
double y1 = EnterNumber();
Console.WriteLine("Enter coordinates X, Y of the Second Point:");
double x2 = EnterNumber();
double y2 = EnterNumber();

Console.Write($"Distance between Points: A({x1}, {y1}) and B({x2}, {y2}) is ");
Console.WriteLine(DistanceBetweenPoints(Sum2(SquareNumber(Diff(x1, x2)), SquareNumber(Diff(y1, y2)))));

