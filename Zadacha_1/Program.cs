//c#
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n * n);

// //задача 1 напшите программу, которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число: ");
// int m = int.Parse(Console.ReadLine()!);
// if (n * n == m)
// Console.WriteLine("Да");
// else
// Console.WriteLine("нет");

// //задача 3 программа, котоая будет выдавать название дня недели 3-среда, 5-пятница
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// while(n < 1 || n > 7)   // || означает "или" (ставится кнопкой "\")
// {
//     Console.Write("Вы ошиблись!\n Введите число: "); //  !\n переход на новую строку сразу
//     n = int.Parse(Console.ReadLine()!);               // {} 2 строчки кода
// }
// if (n ==1)
//   Console.WriteLine("Понедельник");
// else if (n == 2)
//   Console.WriteLine("Вторник");
// else if (n == 3)
//   Console.WriteLine("Среда");
// else if (n == 4)
//   Console.WriteLine("Четверг");
// else if (n == 5)
//   Console.WriteLine("Пятница");
// else if (n == 6)
//   Console.WriteLine("Суббота");
// else 
//   Console.WriteLine("Воскресенье");

// // Задача 5 при введении числа, вывод консоли в промежутке от -n до n
// // через цикл for
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = (-1) * n; i <= n; i++) //или i = -n // i<=n до какого шага идем
//   Console.Write($"{i} ");

//Задача 5 при введении числа, вывод консоли в промежутке
// через цикл while
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), i = (-1) * n;
// n = Math.Abs(n); // модуль числа
// while (i <= n)
// {
//     Console.Write($"{i} ");
//     i++;
// }


//Задача 7 программа которая принимает на вход любое число и при выводе показывает последнюю цифру
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(n % 10);    //делится на 10. в остатке последнее число







