//Задача 7 программа которая принимает на вход любое число и при выводе показывает последнюю цифру
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 10);
