// Задача 60. ...Сформируйте трёхмерный массив из уникальных двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void FillArray(int[,,] col)
{
    int length = col.GetLength(0) * col.GetLength(1) * col.GetLength(2);
    int[] helpArray = new int[length];
    int number;
    for (int m = 0; m < length; m++)
    {
        helpArray[m] = new Random().Next(10, 100);
        number = helpArray[m];
        if (m >= 1)
        {
            for (int l = 0; l < m; l++)
            {
                while (helpArray[m] == helpArray[l])
                {
                    helpArray[m] = new Random().Next(10, 100);
                    l = 0;
                    number = helpArray[m];
                }
                    number = helpArray[m];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            for (int k = 0; k < col.GetLength(2); k++)
            {
                col[i, j, k] = helpArray[count];
                count++;
            }
        }
    }
}



void PrintArray(int[,,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            for (int k = 0; k < col.GetLength(2); k++)
                Console.Write($"{col[i, j, k],3}({i},{j},{k}) \t");
            Console.WriteLine();
        }
            
    }
}





Console.WriteLine("Введите 1-ый размер");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ой размер");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-ий размер");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[x, y, z];
FillArray(array);
PrintArray(array);
Console.WriteLine();






