// Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100)
{
    Console.Write("Вы ошиблись!\nТретьей цифры нет: ");
    n = Convert.ToInt32(Console.ReadLine());
 
if (n < 100 || n > 999)
{
    int n1 = n / 100;
int n2 = n % 10;
    Console.WriteLine($"Третья цифра: {n2}");
}

