/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int Acrement(int n, int m)
{
    if (n ==0)
    {
      return m+1 ;
    }
    else if(m==0)
    {
       return Acrement (n-1,1) ;
    }
    else  return Acrement(n-1, Acrement (n,m-1));
 
}

int acrement=Acrement(3,2);
Console.Write (acrement);
