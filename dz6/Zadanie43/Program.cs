// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int IntInput(string intName)
{
    int num;

    Console.Write($"Введите число {intName}: ");
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Введено недопустимое значение");

    }
    return num;
}

int k1 = IntInput("k1");
int k2 = IntInput("k2");
int b1 = IntInput("b1");
int b2 = IntInput("b2");

double deltaK = k1 - k2;
double deltaB = b1 - b2;
double x = (-1) * deltaB / deltaK;
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых - ({x};{y})");