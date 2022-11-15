// Задача 41: Пользователь вводит с клавиатуры M чисел.  
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

double[] GetArrayOfNumbers()
{
    Console.WriteLine("Введите числа через пробел: ");
    string userMassiv = Console.ReadLine();

    double[] numbers = userMassiv.Split(' ').Select(double.Parse).ToArray();
  
    return numbers;
}

int CountPositiveNumbers(double[] array)
{
    int posNumbers = 0;
    foreach (double el in array)
    {
        if (el > 0) posNumbers++;
    }
    Console.WriteLine($"Положительных чисел {posNumbers}.");
    return posNumbers;
}

Console.WriteLine();
CountPositiveNumbers(GetArrayOfNumbers());
