// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

void numberSum(int num)
{

int result = 0;
int number1 = 0;
int numberTmp = number;

    while (numberTmp > 0)
    {
        number1 = numberTmp % 10;
        result = result + number1;
        numberTmp = numberTmp / 10;
    }

    Console.WriteLine($"Сумма цифр числа {number} равняется {result}");
}

numberSum(number);
