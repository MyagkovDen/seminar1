/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

// 1. Получить строки, содержащие числа
Console.Write("Введите целое число a и нажмите Enter: ");
string userInput1 = Console.ReadLine() ?? "";

Console.Write("Введите число b и нажмите Enter: ");
string userInput2 = Console.ReadLine() ?? "";

// 2. Преобразовать строки в числа
int a = 0;
string message = "";
try
{
    a = int.Parse(userInput1);
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка ввода! {ex.Message}");
}

int b = 0;
try
{
    b = int.Parse(userInput2);
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка ввода! {ex.Message}");
    return;
}

// 3. Определить большее число
int max = 0;
if (a > b)
{
    max = a;
}
else if (a < b)
{
    max = b;
}
else
{
    max = a;
    message = "(Числа равны)";
}


// 4. Вывести большее число на консоль
Console.WriteLine($"a = {a}; b = {b} -> max = {max} {message}");