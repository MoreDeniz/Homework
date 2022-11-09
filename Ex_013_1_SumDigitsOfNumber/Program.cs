// Задача 27: Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе. (Вар. 2)
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();

string InputNumber()
{
    Console.Write("Input the number: ");
string num = Console.ReadLine();
if (int.Parse(num[0].ToString()) == 0)
Console.WriteLine($"Entered incorrectly!");
return num;
}

int SumDigitalsOfNumber(string num)
{
   int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        sum = sum + int.Parse(num[i].ToString());
    }
    Console.WriteLine($"Summa digitals of number {num} = {sum}"); 
    return sum;
}

SumDigitalsOfNumber(InputNumber());
