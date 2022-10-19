//4. Найти расстояние между точками в пространстве 3D
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

double Sum3(double num1, double num2, double num3)   //function: sum of 3 numbers
{
    double sum = num1 + num2 + num3;
    return sum;
}

double SquareNumber(double num)   //function: square of a number
{
    double square = num * num;
    return square;
}

double DistanceBetweenPoints(double num)   //function: Square Root of a number
{
    double distance =  Math.Sqrt(num);
    return distance;
}

Console.WriteLine("Enter coordinates X, Y, Z of the First Point:");
double x1 = EnterNumber();
double y1 = EnterNumber();
double z1 = EnterNumber();
Console.WriteLine("Enter coordinates X, Y, Z of the Second Point:");
double x2 = EnterNumber();
double y2 = EnterNumber();
double z2 = EnterNumber();

Console.WriteLine(Diff(x1, x2)); //checking for difference
Console.WriteLine(Diff(y1, y2));
Console.WriteLine(Diff(z1, z2));

Console.WriteLine(SquareNumber(Diff(x1, x2)));  //checking for square
Console.WriteLine(SquareNumber(Diff(y1, y2)));
Console.WriteLine(SquareNumber(Diff(z1, z2)));

Console.WriteLine(Sum3(SquareNumber(Diff(x1, x2)), SquareNumber(Diff(y1, y2)), SquareNumber(Diff(z1, z2))));  //checking for sum

Console.Write($"Distance between Points: A({x1}, {y1}, {z1}) and B({x2}, {y2}, {z2}) is ");
Console.WriteLine(DistanceBetweenPoints(Sum3(SquareNumber(Diff(x1, x2)), SquareNumber(Diff(y1, y2)), SquareNumber(Diff(z1, z2)))));
