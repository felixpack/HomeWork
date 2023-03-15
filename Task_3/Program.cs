//задача 3 программа, котоая будет выдавать название дня недели 3-среда, 5-пятница
Console.Clear();
Console.Write("Введите день недели(от 1 до 7): ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)  // || означает "или" (ставится кнопкой "\")
{
    Console.Write("Вы ошиблись!\nВведите день недели(от 1 до 7): ");  //!\n переход на новую строку сразу
    n = Convert.ToInt32(Console.ReadLine());    // {} 2 строчки кода
}
if (n == 1)
    Console.WriteLine("Понедельник");
else if (n == 2)
    Console.WriteLine("Вторник");
else if (n == 3)
    Console.WriteLine("Среда");
else if (n == 4)
    Console.WriteLine("Четверг");
else if (n == 5)
    Console.WriteLine("Пятница");
else if (n == 6)
    Console.WriteLine("Суббота");
else
    Console.WriteLine("Воскресенье");
