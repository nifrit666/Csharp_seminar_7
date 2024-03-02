﻿/*
Задача 2: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Пример: 
m = 2, n = 3 => A(m,n) = 29
*/


Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Результат: {FunctionAccerman(m, n)}");

int FunctionAccerman(int num1, int num2)
{
    if (num1 == 0)
    {
        return (num2 + 1);
    }
    else if (num2 == 0)
    {
        return FunctionAccerman(num1 - 1, 1);
    }
    else
    {
        return FunctionAccerman(num1 - 1, FunctionAccerman(num1, num2 - 1));
    }
}