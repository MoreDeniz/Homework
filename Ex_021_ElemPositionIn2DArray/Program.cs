// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int InputNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        bool result = int.TryParse(Console.ReadLine() ?? "0", out var number);
        if (!result)
        {
            Console.WriteLine($"Некорректный ввод! ");
            Thread.Sleep(1500);

            continue;
        }
        return number;
    }
}

int[,] GetMatrix()
{
    int rows = new Random().Next(2, 10);
    int columns = new Random().Next(2, 10);

    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}

bool CheckPosition(int row, int column)
{
    int[,] matrix = GetMatrix();
    bool result = false;
    if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
    {
        result = true;
        Console.Write($"Значение элемента: {matrix[row, column]}");
    }

    return result;
}

int m = InputNumber($"Введите m: ");
int n = InputNumber($"Введите n: ");
Console.WriteLine();
Console.WriteLine(CheckPosition(m, n) ? "" : "Такого числа в массиве нет");
