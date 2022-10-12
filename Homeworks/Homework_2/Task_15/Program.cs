// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfTheWeek >= 1 && dayOfTheWeek <= 5)
{
    Console.WriteLine("Нет, этот день не является выходным");
}
else if (dayOfTheWeek >= 6 && dayOfTheWeek <= 7)
{
    Console.WriteLine("Да, этот день является выходным");
}
else
{
    Console.WriteLine("Введено неверное число");
}