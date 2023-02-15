// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/
int min = 4;
int max = 8;
int count = max;
int arrayLength = (max - min) + 1;
int[] number = new int[(max - min) + 1];

int[] naturalNumber(int x)
{

    if (count < min)
    {
        return number;

    }
    else
    {
        number[arrayLength - 1] = count;
        arrayLength--;
        count--;
        naturalNumber(count);
        return number;
    }
}
int sumOffNumbers(int[] number)
{
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        // Console.Write(number[i] + " ");
        sum += number[i];
    }
    return sum;

}
int mySum = sumOffNumbers(naturalNumber(max - min));
Console.Write($"M = {min}; N = {max} -> {mySum}");