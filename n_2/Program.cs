// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
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

void SearchingMinSum(int[,] col)
{
    int[] helpCol = new int[col.GetLength(0)];
    for (int i = 0; i < col.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < col.GetLength(1); j++)
            sum = sum + col[i, j];
        helpCol[i] = sum;
    }
    
    int min = helpCol[0];
    int minIndex = 0;
    for (int l = 0; l < col.GetLength(0); l++)
    {
        if (helpCol[l] < min) 
        {
            min = helpCol[l];
            minIndex = l;
        }
    }
    Console.WriteLine($"Наименьшая сумма = {min}, номер строки {minIndex + 1}");
}



Console.WriteLine("Введите размерность");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, rows];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SearchingMinSum(array);



