// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int A, int B)
{
  int result = 1;

  for(int count=1; count <= B; count++)
  {
    result = result * A;
  }
    return result;
}

  Console.WriteLine("Введите число A ");
  int.TryParse(Console.ReadLine(), out int A);
  Console.WriteLine("Введите число B ");
  int.TryParse(Console.ReadLine(), out int B);

  int newExponentiation = Exponentiation(A, B);
  Console.WriteLine($"{A} в степени {B} равно {newExponentiation}");
