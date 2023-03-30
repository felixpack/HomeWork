﻿// задайте двумерный массив. найдите элементы, у которых оба индекса нечетные, и замените эти элементы на их квадраты (по столбцу и строчке)

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11); // [10; 10]
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

void ReleaseMatrix(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 1; j < matrix.GetLength(1); j+=2)
            matrix[i, j] *= matrix[i, j];
    }
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
PrintMatrix(matrix);
ReleaseMatrix(matrix);
Console.WriteLine("Конечный массив");
PrintMatrix(matrix);