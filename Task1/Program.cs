//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

void FillArray (int [,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0,10);
        }
    }
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
 
    }
}

double Arithmetic(int [,] array)
{
    double sum = 0;
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    { 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        result = sum/array.GetLength(0);
        Console.Write (result+ "|" );
        sum = 0;
        result = 0;

    }
    return result;
}


int m = ReadInt("Enter the number of rows: ");
int n = ReadInt("Enter the number of colomns: ");

int [,] numbers = new int[m,n];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine("Среднее арифметическое каждого из столбцов равно:");
Arithmetic(numbers);
