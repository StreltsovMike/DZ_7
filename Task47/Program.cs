// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 5, n = 4;
double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 100);
        array[i, j] = array[i, j] / 10;
    }

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write(String.Format("{0,4}", array[i, j]));
    Console.WriteLine();
}