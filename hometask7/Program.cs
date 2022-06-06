// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.


Console.Clear();
double[,] GetArray(int a, int b)
{
    double[,] array = new double[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rndNum.Next(-100, 100) + rndNum.NextDouble(), 2);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
double[,] arr = GetArray(3, 4);
PrintArray(arr);