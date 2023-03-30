int n = Convert.ToInt32(Console.ReadLine());
int[] array = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

int countEven = 0, countOdd = 0;
foreach (int element in array)
{
    if (element % 2 == 1)
    {
        Console.Write($"{element} ");
        countEven++;
    }
}
Console.WriteLine();
foreach (int element in array)
{
    if (element % 2 == 0)
    {
        Console.Write($"{element} ");
        countOdd++;
    }
}
Console.WriteLine();
if (countOdd >= countEven)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");
