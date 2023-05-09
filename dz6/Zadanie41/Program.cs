Console.Write("Введите элементы через пробел и нажмите Enter: ");

int CalculateCount = EnterNumbers();

Console.WriteLine($"из всех введенных чисел {CalculateCount} больше 0");


int EnterNumbers()
{
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
return count;
}
 

