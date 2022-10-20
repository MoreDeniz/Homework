﻿// Выводит вторую цифру 3-значного числа
Console.Clear();
Console.Write("Enter a three-digit number: ");
int num = int.Parse(Console.ReadLine());
int secondDigit = (num / 10) % 10;

Console.WriteLine((num > 99 && num < 1000) 
? $"The second digit in the number {num} = {secondDigit}." 
: $"Entered incorrectly!");