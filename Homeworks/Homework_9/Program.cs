// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

// Console.WriteLine("Введите первое число: ");
// int firstNumber = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int secondNumber = int.Parse(Console.ReadLine());


// int NaturalNumber(int firstNumber, int secondNumber)
// {
//     if (firstNumber == secondNumber) return firstNumber;

//     else
//         Console.Write($"{NaturalNumber(firstNumber, secondNumber - 1)}, ");
//     return secondNumber;
// }

// if (firstNumber < secondNumber)
// {
//     Console.WriteLine(NaturalNumber(firstNumber, secondNumber));
// }
// else Console.WriteLine("Недопустимые числа");



// Задача 66: Задайте значения M и N. 

// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



// Console.WriteLine("Введите первое число: ");
// int firstNumber = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int secondNumber = int.Parse(Console.ReadLine());

// int summ = 0;

// int NaturalNumberSum(int firstNumber, int secondNumber)
// {
//     if (firstNumber < secondNumber) return firstNumber + NaturalNumberSum(firstNumber + 1, secondNumber);

//     else return secondNumber;
// }

// if (firstNumber < secondNumber) 
// {
//     summ = NaturalNumberSum(firstNumber, secondNumber);
//     Console.WriteLine($"Сумма натуральных чисел от {firstNumber} до {secondNumber} -> " + summ);
// }

// else if(firstNumber > secondNumber) Console.WriteLine($"Число {firstNumber} больше числа {secondNumber}");

// else if(firstNumber == secondNumber) Console.WriteLine("Числа равны");




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 

// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29


Console.WriteLine("Введите первое число: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для чисел {firstNumber} и {secondNumber} равна {Ackermann(firstNumber, secondNumber)}");

double Ackermann(double firstNumber, double secondNumber)
{
    if (firstNumber == 0) return secondNumber + 1;

    if (secondNumber == 0 && firstNumber > 0) return Ackermann(firstNumber - 1, 1);

    else return Ackermann(firstNumber - 1, Ackermann(firstNumber, secondNumber - 1));
}

