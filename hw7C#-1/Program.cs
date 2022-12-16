// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк массива: ");
int rows=Convert.ToInt32(Console.ReadLine()); 

Console.Write("Необходимо ввести количество столбцов массива: ");
int columns=Convert.ToInt32(Console.ReadLine());

double[,] arrayDouble = GetArrayDouble(rows, columns, 0, 10); 
PrintArrayDouble(arrayDouble);

double[,] GetArrayDouble(int m, int n, int min, int max) 
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(max-min);
        }
    }
    return result;
}

void PrintArrayDouble(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]:f2} ");
        }
        Console.WriteLine();
    }
}