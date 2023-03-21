// напишите программу, которая принимает  на вход число N и
// выдает произведение чисел от 1 до N


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;// помогает считать цифры в числе
while (n != 0)
{
    count++;
    n = n / 10; // n /= 10
}
Console.WriteLine(count);