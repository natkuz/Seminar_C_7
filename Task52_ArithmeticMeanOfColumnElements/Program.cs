/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] GetArray(int rows, int cols, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[rows, cols];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArithmeticMeanOfColumnElements (int[,] array, int roundDigits = 1)
{
    double sumElementsOfColumns = 0;
    double arithmeticMean = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumElementsOfColumns = sumElementsOfColumns + array[j, i];
        }
        arithmeticMean = Math.Round((sumElementsOfColumns / array.GetLength(0)), roundDigits);
        System.Console.WriteLine($"Среднее арифметическое столбца {i + 1}: {arithmeticMean}");
        arithmeticMean = 0;
        sumElementsOfColumns = 0;
    }
}

int[,] massive = GetArray(
    rows: 3, 
    cols: 4,
    maxValue: 20
    );
PrintArray(massive);
System.Console.WriteLine();
PrintArithmeticMeanOfColumnElements(massive);