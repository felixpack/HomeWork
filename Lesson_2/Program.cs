﻿// // demo task 2 напишите программу, которая выводитслучайное число из отрезка [10, 99] и показывает наибольшую цифру числа

Console.Clear();
int n = new Random().Next(10, 100); // [10, 99] //[10,99] первое число входит, последнее число не входит, поэтому вместо 100 будет 99
Console.WriteLine($"Случайное сгенерированное число {n}");
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n2)
    Console.WriteLine(n1);
else  //если n2 больше или равно n1
    Console.WriteLine(n2);