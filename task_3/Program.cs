/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int Acrement(int n, int m)
{
    if (m ==0)
    {
      return n+1 ;
    }
    else if(n==0)
    {
       return Acrement (n-1,1) ;
    }
    else  return Acrement(n-1, Acrement (n,(m-1)));
 
}


Console.Write (Acrement(2,3));