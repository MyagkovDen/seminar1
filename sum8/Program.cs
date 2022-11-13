/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа 
от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

void FillArray(int[] array)
{
    int lenght = array.Length;
    int index = 0;
    while (index < lenght)
    {
        array[index] = index + 1;
        index++;
    }
}

void FindEven(int[] array)
{
    int lenght = array.Length;
    int index = 0;
    while (index < lenght)
    {
        if (array[index] % 2 == 0)
        {
            Console.Write($"{array[index]}, ");
        }
        index++;
    }
}

Console.Write("Введите число(N): ");
string userInput = Console.ReadLine() ?? "";
int N = int.Parse(userInput);

int[] array = new int[N];

FillArray(array);
Console.Write($"{N} -> ");
FindEven(array);

