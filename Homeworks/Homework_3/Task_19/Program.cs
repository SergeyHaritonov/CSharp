// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

static void palindrome(int number)
{ 

if (number > 9999 && number < 100000)
{
    string numberText = Convert.ToString(number);

    if (numberText[0] == numberText[4] && numberText[1] == numberText[3])
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }

    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}

else if (number < -9999 && number > -100000)
{
    string numberText = Convert.ToString(number);

    if (numberText[1] == numberText[5] && numberText[2] == numberText[4])

    // Индексы увеличены на 1, чтобы "отсечь" минус у отрицательного числа и сравнивать сами цифры

    {
        Console.WriteLine($"Число {number} является палиндромом");
    }

    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}

else
{
    Console.WriteLine("Введено неверное число");
}
}

palindrome(number);
