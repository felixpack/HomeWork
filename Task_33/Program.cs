// задайте массив. напишите программу, которая определяет, присутсвует ли заданное число в массив
// 4 в массиве (6, 7, 19, 345, 3) нет
// 3 в массиве (6, 7, 19, 345, 3) да


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9; 9]
}

string SearchNumberInArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number){
            Console.WriteLine(i);
            return "yes";  // если да, то функция завершится
        }
    }
    return "no";
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Введите число: ");
int k = int.Parse(Console.ReadLine()!);
Console.WriteLine(SearchNumberInArray(array, k));