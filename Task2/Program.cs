﻿/*
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Пример: 
123 = 6
63 = 9


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SummOfGigits(number));

int SummOfGigits(int number) //123 12 1 0
{
    if (number == 0)
    {
        return 0;
    }

    return number%10 + SummOfGigits(number/10); // 123 12 1
    // всегда в таких вызовах идет сначала рекурсивный вызов и только потом вычисления 
    // к вычислениям переёдем только после того, как выполнится условие if (number == 0)
    // т.е. 1%10 + 12%10 + 123%10 + 0 = 6
}

*/

// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

void Main()
{
    int N = ReadInt("Введите число: ");
    System.Console.WriteLine(SumDigitsInNumber(N));
}

int SumDigitsInNumber(int number)
{
    if(number < 1) return 0;
    return number % 10 + SumDigitsInNumber(number / 10);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();
