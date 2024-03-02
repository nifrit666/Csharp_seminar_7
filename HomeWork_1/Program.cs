﻿/*
Задайте значения M и N.
Напишите программу, которая вывдете все натуральные числа в промежутке от M до N.
Использовать рекурсию, не использовать циклы.

Пример: 
M=1; N=5  =>  "1, 2, 3, 4, 5"
M=4; N=8  =>  "4, 5, 6, 7, 8"
*/


Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(m, n);

void NaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);
    }
    else if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1+1, num2);
    }
    else // это и есть условие выхода т.к. после else никуда не пойдем
    {
        Console.Write($"{num1} ");
    }
}