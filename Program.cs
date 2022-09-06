//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

bool row = true;
bool column = true;
int rows = 0;
int columns = 0;
while ((row == false) || (column == false) || (rows == columns))
{
    Console.WriteLine("Введите количество строк в  массиве");
    row = int.TryParse(Console.ReadLine(), out rows);
    Console.WriteLine("Введите количество колонок в  массиве");
    column = int.TryParse(Console.ReadLine(), out columns);
}


int[,] array2D = FillArray(rows, columns);
PrintArray2D(array2D);
Console.WriteLine();
int[] resultSummaArray = SumStringArray(array2D);
PrintArray1D(resultSummaArray);
Console.WriteLine();
int numberString = MinValue(resultSummaArray);
Console.WriteLine($"в указанном массиве наименьшая сумма элементов в строке {numberString}");


int[,] FillArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();
    }
}

void PrintArray1D(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} | ");
    }
}

int[] SumStringArray(int[,] array2D)
{

    int[] sumStringArray = new int[array2D.GetLength(0)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            summa = summa + array2D[i, j];
        }
        sumStringArray[i] = summa;
    }
    return sumStringArray;
}

int MinValue(int[] array)
{
    int min = array[0];
    int flag = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            flag = i;
        }
     
    }
    return flag;   
}