// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/
int n = 8;
int count;
int[] number = new int[n];

int[] naturalNumber(int x)
{

    if (n == x)
    {
        count = n;
    }
    else
    {
        count = x;
    }
    if (count <= 0)
    {
        return number;

    }
    else
    {
        number[count - 1] = count;
        count--;
        naturalNumber(count);
        return number;
    }
}

void printArray(int[] array)
{
    char kavuchki = '"';
    Console.Write($"N = {n} -> {kavuchki}");
    for (int j = array.Length - 1; j > 0; j--)
    {
        Console.Write(array[j] + ", ");
    }
    Console.Write($"{array[0]}{kavuchki}");

}
printArray(naturalNumber(n));
