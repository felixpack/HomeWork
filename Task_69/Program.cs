// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int f(int a, int b)
{
  if (b ==0)
    return 1; 
  return f(a, b - 1) * a;
}


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n, m));