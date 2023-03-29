Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine()!);
int[] beginArray = new int[n];
int[] resultArray = new int[n];
for (int i = 0; i < n; i++)
    beginArray[i] = new Random().Next(1, 11); // [1, 10]
Console.WriteLine($"Начальный массив: [{string.Join(", ", beginArray)}]");
Console.Write("Введите на сколько элементов Вы хотите сдвинуть массив: ");
int k = int.Parse(Console.ReadLine()!);
k = k % n;
if (k > 0)
{
    for (int i = 0; i < k; i++)
        resultArray[i] = beginArray[n - k + i];
    for (int i = 0; i < n - k; i++)
        resultArray[k + i] = beginArray[i];
    Console.WriteLine($"Конечный массив: [{string.Join(", ", resultArray)}]");
}
else
{
    k = -k;
    for (int i = 0; i < k; i++)
        resultArray[n - k + i] = beginArray[i];
    for (int i = 0; i < n - k; i++)
        resultArray[i] = beginArray[k + i];
    Console.WriteLine($"Конечный массив: [{string.Join(", ", resultArray)}]");
}