// //составить частотный словарь элементов двумерного массива. частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// // пример 1

// bool checkElement(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//             return false;
//     }
//     return true;
// }

// int inputMatrix(int[,] matrix, int[] array)
// {
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             if (checkElement(array, matrix[i, j]))
//             {
//                 array[k] = matrix[i, j];
//                 k++;
//             }
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
//     return k;
// }


// void SwapFirstLastString(int[,] matrix, int[] array, int countArray)
// {
//     for (int k = 0; k < countArray; k++)
//     {
//         int count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {       
//                 if (array[k] == matrix[i, j])
//                     count++;
//             }
//         }
//         Console.WriteLine($"Элемент {array[k]} встречается {count} раз");
//     }

// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] coord = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// int[] array = new int[coord[0] * coord[1]];
// Console.WriteLine("Начальный массив: ");
// int countArray = inputMatrix(matrix, array);
// Console.WriteLine();
// Console.WriteLine($"[{string.Join(", ", array)}]");
// SwapFirstLastString(matrix, array, countArray);

// // пример 2
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
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

void DictionaryMatrix(int[,] matrix)
{
    int count = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count = 1;
            if (matrix[i, j] != -100)
            {
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    for (int m = 0; m < matrix.GetLength(1); m++)
                    {  
                        if (matrix[i, j] == matrix[k, m] && (i != k || j != m))
                        {
                            matrix[k, m] = -100;
                            count++;
                        }
                        // PrintMatrix(matrix);
                        // Console.WriteLine();
                    }
                }
                Console.WriteLine($"{matrix[i, j]} встречается {count} раз");
            }
        }
    }
    // PrintMatrix(matrix);
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// size[0] - row
// size[1] - column
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Конечный массив:");
DictionaryMatrix(matrix);