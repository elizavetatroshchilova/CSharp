// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int array = int.Parse(Console.ReadLine());
string s = array.ToString();
int min = 10000;
int max = 100000;
if (array > min && array < max)
{
if (s[0] == s[4] && s[1] == s[3])
{
    Console.WriteLine("Введенное число является палиндромом");
}
else
{
Console.WriteLine("Введенное число не является палиндромом");
}
}
else 
Console.WriteLine("Вы ввели недопустимое значение");