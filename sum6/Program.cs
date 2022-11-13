/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

// 1. Получить строку, содержащую число

Console.WriteLine("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";

// 2. Первести строку в число
int number = int.Parse(userInput);

// 3. Определить, является ли число четным
int a = number % 2;

if(a == 0) 
{
   Console.WriteLine($"{number} -> да");
}
else
{
   Console.WriteLine($"{number} -> нет");
}