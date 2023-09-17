// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArrayX2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],3}   ");
        }
        System.Console.WriteLine();
    }
}

void DZ58(int[,] array, int[,] array_2)
{
    int[,] result_array = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                result_array[i, j] += array[i, k] * array_2[k, j];
            }
        }
    }
    PrintArrayX2(result_array);
}


int[,] array = new int[2, 2]
{
    {2,4},
    {3,2}
};
int[,] array_2 = new int[2, 2]
{
    {3,4},
    {3,3},
};


PrintArrayX2(array);
System.Console.WriteLine();
PrintArrayX2(array_2);
System.Console.WriteLine();
DZ58(array, array_2);
