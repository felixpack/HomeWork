// ...принимает на вход число (N) и выдает таблицу квадратов чисел 
//от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++)
    Console.WriteLine($"{i} ^ 2 = {i * i}");