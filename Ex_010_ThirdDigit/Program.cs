// Вывод третьей цифры введённого числа
Console.Clear();

Console.Write("Enter the number: ");
string num = Console.ReadLine(); //Введённое число в виде строки

if (int.Parse(num[0].ToString()) != 0)
    Console.WriteLine((num.Length < 3)
    ? $"There is no third digit in the number {num}."
    : $"The third digit in the number {num} --> {int.Parse(num[2].ToString())}");
else Console.WriteLine($"Entered incorrectly!");