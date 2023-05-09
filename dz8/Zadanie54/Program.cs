// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateArray() 
{
    int[,] array = new int[3, 4];

    return array;
}

int[,] FillArray(int[,] newArray) 
{
    for(int i = 0; i < newArray.GetLength(0); i++) 
    {
        for(int j = 0; j < newArray.GetLength(1); j++) 
        {
            newArray[i, j] = new Random().Next(1, 10);
            Console.Write(newArray[i,j] + " "); 
        }

        Console.WriteLine();
    }
    Console.WriteLine();

    return newArray;
}

int[,] SortArray(int[,] resultArray) 
{
    for(int i = 0; i < resultArray.GetLength(0); i++) 
    {
        for(int j = 0; j < resultArray.GetLength(1); j++) 
        {
            for(int k = 0; k < resultArray.GetLength(1) - 1 ; k++) 
            {
                if(resultArray[i, k] < resultArray[i, k + 1]) 
                {
                    int permanent = resultArray[i, k + 1];
                   resultArray[i, k + 1] = resultArray[i, k];
                    resultArray[i, k] = permanent;
                }
            }
        }
    }

    return resultArray;
}

void PrintArray(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}



PrintArray(SortArray(FillArray(CreateArray())));