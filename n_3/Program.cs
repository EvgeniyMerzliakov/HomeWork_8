// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
        for (int j = 0; j < col.GetLength(1); j++)
            col[i, j] = new Random().Next(1, 5);
}

void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
            Console.Write($"{col[i, j],3} \t");
        Console.WriteLine();
    }
}

void SumArray(int[,] first, int[,] second, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < first.GetLength(1); k++)
            {
                sum += first[i,k] * second[k,j];
            }
            result[i,j] = sum;
        }
}



Console.WriteLine("Введите мерность матриц");
int N = Convert.ToInt32(Console.ReadLine());
int [,] firstMatrix = new int[N, N];
int [,] secondMatrix = new int[N, N];
int [,] resultMatrix = new int[N, N];

Console.WriteLine("Первый массив");
FillArray(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine();
Console.WriteLine("Второй массив");
FillArray(secondMatrix);
PrintArray(secondMatrix);
Console.WriteLine();
Console.WriteLine("Произведение двух массивов");
SumArray(firstMatrix, secondMatrix, resultMatrix);
PrintArray(resultMatrix);