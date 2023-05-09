// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int FindSum(int m, int n)
{
    if (n > m)
    {
        return n + FindSum(m, n - 1);
    }
    else
    {
        return n;
    }
}


Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine($"Сумма натуральных элементов в промежутке между M и N: {FindSum(M, N)}");