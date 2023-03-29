//напишите программу, которая принимает на вход число и выдает сумму цифр в числе
// 452 =>11

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()!);
int result = 0; 
while (a > 0)
    {
      result += a % 10;
      a /= 10;
    }
Console.WriteLine($"результат: {result}");