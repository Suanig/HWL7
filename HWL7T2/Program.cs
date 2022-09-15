// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

var array1 = GetArray(raws, columns);

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

Console.Write("Введите первую координату элемента в массиве:  ");
int coordX = Convert.ToInt32(Console.ReadLine());
if (coordX > (raws - 1) || coordX < 0)
{
    Console.WriteLine("Элемента с заданной позицией в массиве нет");

}
else
{
    Console.Write("Введите вторую координату элемента в массиве:  ");
    int coordY = Convert.ToInt32(Console.ReadLine());
    if ((coordY > (columns - 1) || coordY < 0))
    {
        Console.WriteLine("Элемента с заданной позицией в массиве нет");
    }
    else 
    {
        PrintArray(array1);
        Console.WriteLine();
        Console.WriteLine($"Выбраннный элемент данного массива - {array1[coordX, coordY]}");
    }
}


