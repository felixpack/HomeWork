//задача 1 напшите программу, которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
if (m * m == n)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");