// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
 int Sum()
 {
    int s = 0;
    while(a > 0)
    {
        s += a%10;
        a /= 10;
    }
    return s;
 }
 int result = Sum();
 Console.WriteLine(result);
 
