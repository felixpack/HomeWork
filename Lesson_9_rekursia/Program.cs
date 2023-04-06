// Необходимо сложить 2 числа с помощью рекурсии
// 5 6 -> 11
int f(int a, int b)
{
  if (a == 0)
    return b;
  return f(a - 1, b + 1);
}

Console.Clear();
Console.WriteLine(f(5, 3));

// f(5, 3) -> f(4, 4) -> f(3, 5) -> f(2, 6) -> f(1, 7) -> f(0, 8) -> 8