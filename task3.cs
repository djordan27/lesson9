// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int ackerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return ackerman(n - 1, 1);
    if (n > 0 && m > 0) return ackerman(n - 1, ackerman(n, m - 1));
    return ackerman(n, m);
}
int m = 2;
int n = 3;
int m1 = 3;
int n1 = 2;

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {ackerman(m, n)}");
Console.WriteLine($"m = {m1}, n = {n1} -> A(m,n) = {ackerman(m1, n1)}");