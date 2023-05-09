Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int calculateSum(int number)
{
int sum = 0;
string s = number.ToString();

for (int i = 0; i < s.Length; i++)
{
    sum = sum + int.Parse(s[i].ToString());
}

return sum;
}

int newSum = calculateSum(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {newSum}");