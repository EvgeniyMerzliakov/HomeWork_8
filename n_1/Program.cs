// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 100);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}

void SortArray(int[,] col)
{
    int max = col[0, 0];
    int min = col[0, 0];
    for (int i = 0; i < col.GetLength(0); i++)
        for (int j = 0; j < col.GetLength(1); j++)
            for (int j2 = 0; j2 < col.GetLength(1); j2++)
                if (col[i, j2] < col[i, j]) 
                    (col[i, j2], col[i, j]) = (col[i, j], col[i, j2]); 
}



Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);