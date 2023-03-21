// // Array
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); // [1, 10]
// Console.WriteLine($"[{string.Join("   ,    ", array)}]");


//генерация случайных дробных чисел
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
// ... = new Random.NextDouble() * (end - begin) + begin;
for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (30 - 10) + 10, 2);  //Math.Round округление до 2
Console.WriteLine($"[{string.Join(", ", array)}]");