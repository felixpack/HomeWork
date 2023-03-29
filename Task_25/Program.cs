// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать функцию Math.Pow()!
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;  //если значение 0, то результат будет 0


for (int i = 0; i < b; i++)
    result *= a;
Console.WriteLine($"результат: {result}");