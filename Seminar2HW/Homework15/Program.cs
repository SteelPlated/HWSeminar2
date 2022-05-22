// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

/*Console.Write("Введите номер дня недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number == 6 || Number == 7)
{
    Console.WriteLine("(Выходной) -> да");
}
else
if (Number < 1 || Number > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
else
    Console.WriteLine("(Не является выходным) -> нет");*/

Console.Write(" Введите число дня недели 1 до 7 : ");
var day = Convert.ToInt32(Console.ReadLine());
string[] isWeekend = { " no ", " no ", " no ", " no ", " no ", " y ", " y " };
if (day > 0 && day < 8)
{
    Console.WriteLine(isWeekend[day - 1]);
}
else Console.WriteLine(" Вы ввели некорректиое значение ! ");
