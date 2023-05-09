// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max;
if (a>b)
{
    Console.Write("max=");
    Console.Write((a));
}
else
{
    Console.Write("max=");
    Console.Write((b));
}

// Console.WriteLine("Введите три числа");
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());
// int max = a;
// if (a>b & a>c) 
// {
// max = a;
// Console.WriteLine(max);
// }
// else if (b>a & b>c)
// {
//     max =b;
//     Console.WriteLine(max);
// }
// else 
// {
// if(c>a & c>b)
// max = c;
// Console.WriteLine(max);
// }

// Console.WriteLine("Введите число");
// int a = int.Parse(Console.ReadLine());
// if (a % 2 == 0)
// {
//     Console.WriteLine("Число четное");
// }
// else
// {
//     Console.WriteLine("Число нечетное");
// }


// Console.WriteLine("Введите число");
// int a = int.Parse(Console.ReadLine());
// int i = 1;
// while (i<a)
// {
//     if (i % 2 == 0)
// {
//     Console.Write(i + ", ");
//     i ++;
// }
// else
// {
//     i++;
// }
