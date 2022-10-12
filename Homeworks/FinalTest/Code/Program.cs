// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []


Console.WriteLine("Введите элементы через пробел:");
string[] enteredElements = Console.ReadLine().Split(" ");

Console.WriteLine();

Console.WriteLine("Исходный массив:");
PrintArray(enteredElements);
System.Console.WriteLine();
Console.WriteLine("Получившийся массив:");
PrintArray(SortArray(enteredElements));

String[] SortArray(string[] array)
{
    int resultArrayLength = 0;
    int m = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) resultArrayLength++;
    }

    string[] resultArray = new string[resultArrayLength];

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            resultArray[m] = array[j];
            m++;
        }
    }

    return resultArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}


