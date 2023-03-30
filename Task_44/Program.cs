//не используя рекурсию, выведите первые N чисел Фибоначчи. первые 2 чсла Фиббоначчи:0 и 1
//Если n = 5 => 01123

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int a0 = 0, a1 = 1, x;
for (int i = 0; i < n; i++)
{
    Console.Write($"{a0} ");
    x = a0 + a1;
    a0 = a1;
    a1 = x;
}