//ввод нескольких чисел в 1 строку
// Join <-> Split
Console.Clear();
int[] size = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
Console.WriteLine(size[0] + size[1]);
