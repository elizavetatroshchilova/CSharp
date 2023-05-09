// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
string s = n.ToString();
int number = s.Length;
if (number > 2)
{
    Console.WriteLine(s[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}