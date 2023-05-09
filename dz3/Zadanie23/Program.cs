// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out int n); 
int index = 1;
while (index <= n)
{
   int result = (int)Math.Pow(index, 3); 
   Console.Write($"{result} ");
   index++;
}