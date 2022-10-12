// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    string result = Convert.ToString(number);
    Console.WriteLine($"Третья цифра числа {number}: " + result[2]);
}

else if (number < -99)
{
    string result = Convert.ToString(number);
    Console.WriteLine($"Третья цифра числа {number}: " + result[3]);
}

else
{
    Console.WriteLine($"У числа {number} третьей цифры нет");
}