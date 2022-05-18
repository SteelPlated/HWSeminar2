// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

Console.Write("Введите трехзначное число :");
int a = int.Parse(Console.ReadLine());

int first = a / 100;
int last = a % 10;
int res = (a - first * 100 - last) / 10;
Console.WriteLine($"Результат = {res}");