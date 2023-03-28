
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10 , 10);
}
int SumNechet(int[] array)
{   
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {   if(i % 2 != 0){
        sum += array[i];}
    }
    return sum;
}

Console.Clear();
int[] array = new int[5];
InputArray(array);
System.Console.WriteLine($"array: [{string.Join(" , " , array)}]");
System.Console.WriteLine($"Сумма элементов на нечетных позициях: {SumNechet(array)}");