// // задайте массив из 12 элементов, заполненный случайным числами из промежутка
// [-9,9]. Найдите сумму отрицательных и положительных элементов массива.
// например, в массиве [3.9.-8.1.0.-7.2.-1.8.-3.-1.6] сумма 
// положительных чисел равна 29, сумма отрицательных равно -20


//сначала задаются процедуры  функции
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9; 9]
}

int SumPositiveNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sum += array[i]; // sum = sum + array[i]
    }
    return sum;
}

int SumNegativeNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sum += array[i]; // sum = sum + array[i]
    }
    return sum;
}

// далее основной код

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array); //заполнили массив
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма положительных элементов равна {SumPositiveNumbers(array)}");
Console.WriteLine($"Сумма отрицательных элементов равна {SumNegativeNumbers(array)}");