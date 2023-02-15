/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int OutNumber(int n, int m, int summ)
{
    if (m <= n)
    {

        summ = m + OutNumber(n, m + 1, summ);
    }
    return summ;
}
Console.Write(OutNumber(8, 4, 0));