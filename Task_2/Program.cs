// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Ведите 1-ое число: ");  
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
  Console.WriteLine($"Результат: равны");
else if (a > b)
  Console.WriteLine($"Результат: {a} > {b}");
else
  Console.WriteLine($"Результат: {a} < {b}");
