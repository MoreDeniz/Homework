// Задача 27: Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();

int NumberLength(int num)   // количество цифр числа
{
    int size = num.ToString().Length;
    return size;
}

void GetArrayOfDigits(int[] arr, int num, int size) // массив цифр числа
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = num % 10;
        num /= 10;
        //Console.Write($"{arr[i]}  ");   // проверка: вывод массива
    }
    //Console.WriteLine();
}

int SumDigits(int[] array)  // сумма цифр числа
{
    int size = array.Length;
    int sumDigit = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sumDigit = sumDigit + array[i];
        //Console.WriteLine(sumDigit);    // проверка: промежуточные вычисления
    }
    return sumDigit;
}

Console.Write("Input the number: ");
int num = int.Parse(Console.ReadLine() ?? "0"); //Введённое число
int[] arr = new int[NumberLength(num)];
GetArrayOfDigits(arr, num, NumberLength(num));
SumDigits(arr);
Console.WriteLine($"The sum of the digits of the number {num} = {SumDigits(arr)}");
