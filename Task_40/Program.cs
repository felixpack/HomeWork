// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//напишите программу, котороая принимает на вход 3 числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины

//теорема о неравенстве треугольника: каждая сторона треугольника мкньше суммы двух других сторон

Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-ое число: ");
int c = int.Parse(Console.ReadLine()!);
if(a + b > c && b + c > c && a + c > b)
  Console.WriteLine($"yes");
else
  Console.WriteLine("no");



