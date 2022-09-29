//  Задайте значение N. Напишите программу, которая 
//  выведет все натуральные числа в промежутке от N до 1. 
//  Выполнить с помощью рекурсии.

int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNum (int number)
{
    if(number < 1)
    {
        return;
    }

    System.Console.WriteLine(number);

    number = number -1;
    ShowNum(number);
    
}

int N = DataEntry("Введите натуральное число ");
ShowNum(N);


