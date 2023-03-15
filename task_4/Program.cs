// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Ведите 1-ое число: ");  
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите 3-ое число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b & a > c)
  Console.WriteLine(a);
if (b > a & b > c)
  Console.WriteLine(b);
if (c > b & c > b)
  Console.WriteLine(c);
