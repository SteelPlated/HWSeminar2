// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

Console.Write ("Введите трехзначное число :");
int a = int.Parse(Console.ReadLine());
if ((a<1000)&&(a>99))
    {int first = a/100;
    int last = a%10;
    int res =(a - first * 100 - last)/10;
    Console.WriteLine($"Результат = {res}");}
else Console.WriteLine("Ваше число не подходит. Нужно ТРЕХЗАЧНОЕ!!!");