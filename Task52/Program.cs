// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 5, n = 6;
int[,] array = new int[m, n];                 //Зададим массив с рандомными числами

for (int i = 0; i < m; i++)                        
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(-10, 11);
    }


for (int i = 0; i < m; i++)                           //Выведеем массив в терминал
{
    for (int j = 0; j < n; j++)
        Console.Write(String.Format("{0,4}", array[i, j]));
    Console.WriteLine();
}


double columnSum = 0;

for (int j = 0; j < n; j++)                            //Подсчитаем среднее арифметическое столбцов
                                                       //и выведем в терминал
{
    for (int i = 0; i < m; i++)
    {
        columnSum = columnSum + array[i, j];
    }
    Console.WriteLine($"Среднее арифметическое {j + 1} столбца = {Math.Round(columnSum / m, 2, MidpointRounding.ToEven)}");
    columnSum = 0;
}