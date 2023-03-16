// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 999)
{
    Console.Write("Вы ошиблись!\nВведите Трёхзначное число (от 100 до 999): ");
    n = Convert.ToInt32(Console.ReadLine());
} 
Console.WriteLine($"Введенное трёхзначное число {n}");
int n1 = n / 100;
int n3 = n % 10;
Console.WriteLine($"Вторая цифра: {(n - n1 * 100 - n3) /10}");