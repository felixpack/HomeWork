//Найдите произведение пар чисел в одномерном массиве. парой считаем первый и последний элемент, второй и предпоследний
// и т.д.. результат запишите в новом массиве.
//[1 2 3 4 5]=> 5 8 9

//n/2 + 1 для нечетного (n%2)
//n /2 для четного (n%2)


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [1, 10]
}

void ProizvedenieElements(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        Console.Write($"{array[i] * array[array.Length - 1 - i]} "); //предпоследний элемент -1
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ProizvedenieElements(array);

//урок окончен