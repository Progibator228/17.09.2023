// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
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
void FillArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void RowSum(int[,] array)
{
    int buf = 0;
    int min_sum = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (buf == 0)
        {
            buf = sum;
            min_sum = i;
        }
        else if (sum < buf)
        {
            buf = sum;
            min_sum = i;
        }
        System.Console.WriteLine($"Сумма строки  {i} = {sum}");
        sum = 0;
    }
    System.Console.WriteLine($"Минимальная сумма которую нашли  = {buf}");
    System.Console.WriteLine($"Которая находиться на строке     № {min_sum}");
}
System.Console.WriteLine("Длина Строк");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Длина Столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row, cols];
FillArray(array);
PrintArrayX2(array);
RowSum(array);