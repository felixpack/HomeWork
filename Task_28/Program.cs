// напишите программу, которая принимает  на вход число N и
// выдает произведение чисел от 1 до N (1*2*3*4 =24)



Console.Clear();
System.Console.WriteLine("Vvedite chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
int f = 1;
while(a<=n){
    f=a*f;
    a++;
}
System.Console.WriteLine(f);

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 1;
// for (int i = 2; i <= n; i++)
//     count = count * i;
// Console.WriteLine(count);
