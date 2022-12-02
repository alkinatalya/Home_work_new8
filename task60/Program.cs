/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
 двузначных чисел. Напишите программу, которая будет построчно выводить
  массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] GetArrayRandom(int rows, int cols, int layer, int minValue = 10, int maxValue = 99)
{
    int[,,] array3D = new int[rows, cols, layer];
    var rnd = new Random();
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[i, j, z] = rnd.Next(minValue, maxValue + 1);
            }
        }
    }
    return array3D;
}
void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                Console.Write($" {array3D[i, j, z]} ({i}, {j}, {z})");

            }
            System.Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[,,] array3D = GetArrayRandom(2, 2, 2);
PrintArray(array3D);