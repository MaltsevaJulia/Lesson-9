// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.


int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNum (int M, int N, int sum)
{
    if(M<N)
    {
        System.Console.WriteLine("Сумма натуральных чисел в промежутке от М до N");
        System.Console.WriteLine(sum);
        return;
    }

    sum = sum + M;
 
    M = M - 1;
    ShowNum(M, N, sum);
}
 


int M = DataEntry("Введите натуральное число M ");
int N = DataEntry("Введите натуральное число N ");

if(M>N)
{
   ShowNum(M, N, 0);
}
else 
{
    ShowNum(N, M, 0);
}


