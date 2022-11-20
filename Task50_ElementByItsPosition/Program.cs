/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

void PrintElementByItsPosition(int[,] array, int rowPosition, int colPosition)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    if(rowPosition < rows && colPosition < columns)
    {
        System.Console.WriteLine(array[rowPosition, colPosition]);
    }
    else
    {
        System.Console.WriteLine("Такого числа в массиве нет");
    }
    
}

int[,] massive = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

PrintElementByItsPosition(massive, 1, 7);