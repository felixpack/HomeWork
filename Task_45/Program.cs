// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//которая будет создавать копию заданного массива с помощью поэлементного капирования


Console.Clear();
int[] a = {1, 2, 3, 4, 5};
int[] b = new int[a.Length];

for (int i = 0; i < a.Length; i++)
    b[i] = a[i];

b[0] = b[0] + 10;
Console.WriteLine(string.Join(" ", a));
Console.WriteLine(string.Join(" ", b));
