// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumNumbers(int num1, int num2, int sum = 0)
{
    if (num1 == num2)
    {
        return sum += num1;
    }
    else
    {
        sum += num1;
        return GetSumNumbers(++num1, num2, sum);
    }
}

int num1 = GetNumber("Введите число M: ");
int num2 = GetNumber("Введите число N: ");
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна: {GetSumNumbers(num1,num2)}");