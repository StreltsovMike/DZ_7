// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int m = 10, n = 10;
int[,] array = new int[n, m];

for (int i = 0; i < n; i++)                           //Пусть наш массив будет таблицей умножения
    for (int j = 0; j < m; j++)
    {
        array[i, j] = (i + 1) * (j + 1);
    }

Console.Write("Значение Х - ");
int xLine = Convert.ToInt32(Console.ReadLine());

Console.Write("Значение Y - ");
int yLine = Convert.ToInt32(Console.ReadLine());

if (xLine > -1 && xLine < 11 && yLine>-1 && yLine<11)
        {Console.WriteLine($"Ваше число {array[xLine - 1, yLine - 1]} ");}
    else
    {Console.WriteLine("Error");}
                                                                    //Вывод таблицы умножения
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     Console.Write(String.Format("{0,4}", array[i, j]));
//     Console.WriteLine();
// }