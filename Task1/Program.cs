/*
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
Пример: 
N = 5  =>  1 2 3 4 5 



Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if (num == 0)
    {
        return;
    }

    NaturalNumbers(num - 1); // оно уменьшается здесь 
    Console.Write($"{num} ");
}

*/

// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

void Main()
{
    int N = ReadInt("Введите число: ");
PrintNumbers(N);
}

void PrintNumbers(int number)
{
    if (number < 1) return;
    PrintNumbers(number - 1);
    System.Console.Write(number + " ");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();