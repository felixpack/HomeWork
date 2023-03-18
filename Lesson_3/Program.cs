// напишите программу, которая будет находить сумму цифр числа (цифры 0 -9)
Console.Clear();
string s = Console.ReadLine()!;
int sum = 0;
//теория на уроке

// // ! исключаем значение null
// Char n = '6';
// Console.WriteLine(Convert.ToInt32(s[0].ToString()) * 10);

for (int i = 0; i < s.Length; i++)
    sum = sum + int.Parse(s[i].ToString());
Console.WriteLine(sum);