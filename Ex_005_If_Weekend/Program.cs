//1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();
Console.Write("Введите число от 1 до 7, соответствующее дню недели: ");
int num = int.Parse(Console.ReadLine()!);

string[] week = { "будний", "будний", "будний", "будний", "будний", "выходной", "выходной" };
int n = week.Length;

if (num < n + 1 && num > 0)
{
    Console.WriteLine($"Это {week[num - 1]} день.");
}
else
{
    Console.WriteLine($"Вы ввели некорректное число");
}
