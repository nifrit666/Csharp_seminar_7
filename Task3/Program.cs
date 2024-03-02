/*
Считать строку с консоли, содержащую латинские буквы. 
Вывести на экран согласные буквы этой строки.

Пример: 
"hello" => h l l
"world" => w r l d
"Hello world" =>  H l l w r l d


void PrintConsonants(int index, string AllSymbol)
{
   // A,a,E,e,I,i,O,o,U,u,Y,y
   //int AllSymbol = AllSymbol.ToLower();
   if (index > AllSymbol.Length - 1)
   {
       return;
   }
   char t = char.ToLower(AllSymbol[index]);
   if (t != 'e' && t != 'a' && t != 'o' && t != 'i' && t != 'u' && t != 'y')
   {
       Console.Write($"{AllSymbol[index]} ");
   }
   PrintConsonants(index + 1, AllSymbol);
}


Console.WriteLine("Введите строку, содержащую латинские буквы: ");
string StringAllSymbol = Console.ReadLine();
PrintConsonants(0, StringAllSymbol);


// ВАРИАНТ 1

// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

void Main()
{
    System.Console.Write("Введите строку: ");
    string? inputString = Console.ReadLine();
    PrintConsonants(inputString);
}

void PrintConsonants(string str, int index = 0)
{
    if (index >= str.Length) return; // Проверяем, не вышли ли за границы строки

    char c = char.ToLower(str[index]); // Из строки получаем символ и переводим его в нижний регистр V

    if (IsConsonant(c))
        System.Console.Write(str[index] + " ");

    PrintConsonants(str, index + 1);
}

bool IsConsonant(char c)
{
    return "bcdfghlmnpqrstvxzk".Contains(c);
}

Main();

*/

// ВАРИАНТ 2

Console.Write("Введите строку латинскими буквами: ");
string? str = Console.ReadLine();
RemoveVowels(str);

void RemoveVowels(string? str)
{
    if (str.Length == 1)
    {
        if (!IsContainVowels(str[0])) Console.Write($"{str}");
        return;
    }

    if (!IsContainVowels(str[0]) && str[0] != ' ') Console.Write($"{str[0]} ");
    RemoveVowels(str.Remove(0, 1));
}

bool IsContainVowels(char ch)
{
    return "aeiouy!,.:".Contains(ch);
}
