// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 Console.WriteLine("Введите трехзначное число");
int.TryParse(Console.ReadLine(), out int a);
int min = 100;
int max = 1000;
int b = a / 10 % 10;
if (a > min && a < max)
{
    Console.WriteLine($"Вторая цифра {b} ");
}
else
{
    Console.WriteLine("Вы ввели недопустимое значение");
}