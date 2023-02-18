// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();

    }
}
int m = ReadInt("Enter the number of rows: ");
int n = ReadInt("Enter the number of colomns: ");

int[,] numbers = new int[m, n];
FillArray(numbers);
PrintArray(numbers);
int sum = 0;
int[] result = new int[numbers.GetLength(0)];
for (int i = 0; i < numbers.GetLength(0); i++)
{

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];
    }
    result[i] = sum;
    sum = 0;
}
int max = 0;
for (int i = 0; i < result.Length; i++)
{
    if (result[i] > result[max])
    {
        max = i;
    }
}
Console.WriteLine($"Номер строки с максимальной суммой элементов {max+1}");


