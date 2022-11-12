/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/



// 1. Получить строки, содержащие 3 числа
Console.Write("Введите целое число a и нажмите Enter: ");
string userInput1 = Console.ReadLine() ?? "";

Console.Write("Введите целое число b и нажмите Enter: ");
string userInput2 = Console.ReadLine() ?? "";

Console.Write("Введите целое число c и нажмите Enter: ");
string userInput3 = Console.ReadLine() ?? "";

// 2. Перевести строки в числа

int a = int.Parse(userInput1);
int b = int.Parse(userInput2);
int c = int.Parse(userInput3);

// 3. Определить максимальное число
int max = a;

if(b > max) max = b;
if(c > max) max = c;

// 4. Вывести результат в консоль

Console.WriteLine($"{a}, {b}, {c} -> {max}");