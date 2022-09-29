// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

int m = DataEntry("Введите неотрицательное число m ");
int n = DataEntry("Введите неотрицательное число n ");
int res;
res = A(m, n);

System.Console.WriteLine(res);