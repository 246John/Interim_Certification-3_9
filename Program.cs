/* Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = 8;
int m = 0;
string NumbersList(int n, int m)
{
    if (n == m)
    {
        return "";
    }
    return NumbersList(n, m + 1) + $"{m += 1} ";
}

Console.WriteLine(NumbersList(n, m));
*/

/* Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

int n = 4;
int m = 8;
int NumbersList(int n, int m)
{
    if (n == m)
    {
        return n;
    }
    return NumbersList(n + 1, m) + n;
}

Console.WriteLine(NumbersList(n, m));
*/

/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 

int m = 3;
int n = 2;

int fA(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if (m > 0 && n == 0)
    {
        return fA(m -1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return fA(m -1, fA(m, n-1));
    }
    return fA(m -1, n -1);
}

Console.WriteLine(fA(m,n));
*/