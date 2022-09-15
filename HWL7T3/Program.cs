// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int raws = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);

double[,] GetArray(int m, int n)
{
    var result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-1000, 1000);
        }
    }
    return result;
}


double[] GetColumsSrA(double[,] arr)
{
    var result = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j, i];
        }
        result[i] = Math.Round(sum / arr.GetLength(0), 2);

    }
    return result;
}

foreach (var item in GetColumsSrA(GetArray(raws, columns)))
{
    Console.WriteLine(item);
}


