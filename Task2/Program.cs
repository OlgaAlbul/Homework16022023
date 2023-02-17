// Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.

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

void SortArray (int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
			int min = j;
            for (int l = j+1; l<array.GetLength(1); l++)
            {
                if (array[i,l] < array[i,min])
                {
                    min = l;
                }
                
            }
            int value = array[i,j];
                array[i,j] = array[i,min];
                array[i,min] = value;
        }
    }
}

int m = ReadInt("Enter the number of rows: ");
int n = ReadInt("Enter the number of colomns: ");

int [,] numbers = new int[m,n];
FillArray(numbers);
PrintArray(numbers);

/*for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1)-1; j++)
        {
			int min = j;
            for (int l = j+1; l<numbers.GetLength(1); l++)
            {
                if (numbers[i,l] < numbers[i,min])
                {
                    min = l;
                }
                
            }
            int value = numbers[i,j];
                numbers[i,j] = numbers[i,min];
                numbers[i,min] = value;
        }
    }
    */
    Console.WriteLine("Упорядоченный массив: ");
    SortArray(numbers);
    PrintArray(numbers);