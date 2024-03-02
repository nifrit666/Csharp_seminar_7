﻿/*
Задача 3: 
Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.

Пример: 
[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1
*/


int[] arr = { 1, 2, 5, 0, 10, 34 };
PrintReverseArray(arr, 0); 

void PrintReverseArray(int[] Array, int index)
{
    if (index > Array.Length - 1) 
    {
        return;
    }

    PrintReverseArray(Array, index + 1);
    Console.Write(Array[index] + " ");
}