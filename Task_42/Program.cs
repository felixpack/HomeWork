

//напишите программу, которая будет преобразовывать десятичное число
// в двоичное

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
string result = string.Empty;// преобразование в строку, чтобы не складывало
while (n > 0)
{
    result = Convert.ToString(n % 2) + result;
    n /= 2;
}
Console.WriteLine(result);









