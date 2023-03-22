// напишите программу, которая принимает  на вход число N и
// выдает произведение чисел от 1 до N (1*2*3*4 =24)



Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
for (int i = 2; i <= n; i++) // факториал 1 равен 1, по-этому с 2х
    count = count * i;
Console.WriteLine(count);
