// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray(int[,] someArray)
{
    int[,] EmptyArray = new int[4, 4];
    return EmptyArray;
}

int[,] FillArray(int[,] emptyArray)
{
    for (int i = 0; i < emptyArray.GetLength(0); i++)
    {
        for (int j = 0; j < emptyArray.GetLength(1); j++)
        {
            emptyArray[i, j] = new Random().Next(1, 10);
            Console.Write(emptyArray[i, j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    return emptyArray;
}

int[] CalculateSum(int[,] filledArray)
{
    Console.Write("Суммы строк равны: ");
    int[] sumOfElements = new int[filledArray.GetLength(0)];
    for (int i = 0; i < filledArray.GetLength(0); i++)
    {
        int sumOfRow = 0;
        for (int j = 0; j < filledArray.GetLength(1); j++)
        {
            sumOfRow += filledArray[i, j];
        }

        sumOfElements[i] = sumOfRow;
        Console.Write($"{sumOfElements[i]} ");
    }

    return sumOfElements;
}


void FindMinimalSum(int[] array)
{
    int min = array[0];
    int numberOfRow = 1;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < min)
        {
            min = array[i];
            numberOfRow = i + 1;
            i++;

        }
        else i++;

    }
    Console.WriteLine($"Минимальная сумма элементов в троке номер {numberOfRow}");

}

int[,] someArray = new int[4, 4];
int[,] result = CreateArray(someArray);
FindMinimalSum(CalculateSum(FillArray(result)));