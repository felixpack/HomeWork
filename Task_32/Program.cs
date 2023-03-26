// напишите программу элемента массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4,-8,8,2] на [4,8, -8,-2]

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9; 9]
}

void ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1); //перевернули массив
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array); //заполнили массив
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ChangeArray(array);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");