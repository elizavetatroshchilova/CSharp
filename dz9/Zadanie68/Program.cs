// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int CalculateAckermann(int m, int n) 
{
    if(m == 0)
    {
        return n + 1;
    }
    
    else if(m > 0 && n == 0) 
    {
        return CalculateAckermann(m - 1, 1);
    }
    return CalculateAckermann(m - 1, CalculateAckermann(m, n - 1));
}


Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine($"Результат: {CalculateAckermann(M, N)}");