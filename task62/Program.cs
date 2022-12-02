/*Задача 62. Напишите программу, которая заполнит спирально массив
 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
int size = 4;
int[,] spiralArray = new int[size, size];
int temp = 1;
int SpiralArray(int[,] spiralArray)
{
    int rows = 0;
    int cols = 0;

    while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
    {
        spiralArray[rows, cols] = temp;
        temp++;
        if (rows <= cols + 1 && rows + cols < spiralArray.GetLength(1) - 1)
            cols++;
        else if (rows < cols && rows + cols >= spiralArray.GetLength(0) - 1)
            rows++;
        else if (rows >= cols && rows + cols > spiralArray.GetLength(1) - 1)
            cols--;
        else
            rows--;
    }
    return temp;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
SpiralArray(spiralArray);
PrintArray(spiralArray);