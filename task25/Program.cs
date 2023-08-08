// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите основание: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int y = Convert.ToInt32(Console.ReadLine());
int Sum(int a, int b)
{
    int pow = 1;
    for (int i=1; i <= b; i++)
    {
        pow = pow * a;
    }
    return pow;
}
int result = Sum(x, y);
Console.WriteLine(result);
