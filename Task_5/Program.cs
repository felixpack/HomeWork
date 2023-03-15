// Задача 5 при введении числа, вывод консоли в промежутке от -n до n
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), i = (-1) * n;
n = Math.Abs(n); // модуль числа
// for (int i = (-1) * n; i <= n; i++)   //или i = -n // i<=n до какого шага идем
//     Console.Write($"{i} ");
while (i <= n)
{
    Console.Write($"{i} ");
    i++;
}
