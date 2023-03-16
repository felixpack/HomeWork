// напишиту программу, котороая будет принимать на вход 2 числа и выводить, является ли второе число кратное первому. Если число 2 не кратно числу 1, то программа выведет остаток от деления
Console.Clear();
Console.Write("Ведите 1-ое число: ");  
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n % m == 0) // остаток при делении равен 0
  Console.Write("кратно ");
else
  Console.Write($"не кратно, остаток  {n % m}");
