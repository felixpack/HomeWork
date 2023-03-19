
// ..., которая принимает на вход координаты 2 точек и находит 
//hасстояние между ними в 2Д пространстве

//double не целое число

Console.Clear();
Console.Write("Введите координату Х(1): ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y(1): ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x(2): ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y(2): ");
double y2 = Convert.ToDouble(Console.ReadLine());
double s = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между двумя точками равно {Math.Round(s, 2)}");