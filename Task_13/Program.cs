// Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.Write("Вы ошиблись!\nТретьей цифры нет: ");

else 
{  
    while (n > 1000)
      n /= 10;
      Console.WriteLine(n % 10);
}

