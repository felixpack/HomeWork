﻿// задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Amn= m+n. Выведите полученный массив на экран
// Задайте дыумерный массив размером m*n, заполненый случайными целыми цифрами
// m=3, n=4
// 14819
// 5 -2 33 -2
// 77 3 8 1 


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = i + j;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix); //вводить 2 цифры