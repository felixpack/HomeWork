﻿//  Задайте массив заполненный случайными положительными трёхзначными числами.
//   Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); 
}

int number(int[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {   if(array[i] % 2 == 0){
        count  += 1;}
    }
    return count;
}

Console.Clear();
int[] array = new int[10];
InputArray(array);
System.Console.WriteLine($"array: [{string.Join(" , " , array)}]");
System.Console.WriteLine($"Четных чисел: {number(array)}");


