// Напишите программу, которая принимает на вход координаты точки (х,у),
// причем х и у не равны 0 и выдает номер четверти плоскости, в которой находится точка

Console.Clear();
Console.Write("Введите координату Х: ");
// ввод дробных чисел. т.к. пользователь может ввести и такое
double x = Convert.ToDouble(Console.ReadLine()); 
//если хотим ввести дробную часть при вводе, то через точку
// double n = 1.56
Console.Write("Введите координату y: ");
double y  = Convert.ToDouble(Console.ReadLine());
while (x==0) //Если пользователь ошибется в Х, а У верна
{
    Console.Write("Вы ошиблись!\nВведите координату х: ");
    x = Convert.ToDouble(Console.ReadLine());
}
while (y==0)
{
    Console.Write("Вы ошиблись!\nВведите координату y: ");
    y = Convert.ToDouble(Console.ReadLine());
}
if(x > 0 && y > 0)
    Console.WriteLine("1");
else if (x < 0 && y > 0)
    Console.WriteLine("2");
else if (x < 0 && y < 0)
    Console.WriteLine("3");
else
    Console.WriteLine("4");

// ответ: в терминале выводим через запятую дробные числа




