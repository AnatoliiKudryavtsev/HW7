// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
//  этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Write("Введите количество строк массива: ");
int rows=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число для проверки наличия данного числа в массиве: ");
int number=Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns,0,3); 
PrintArray(array); 

if(FindNumber(array,number)) 
{
    Console.WriteLine( $"Число найдено {number}");
}
else
{
    Console.WriteLine("Введенного числа в массиве нет");
}

int[,] GetArray(int m, int n, int min, int max) 
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] inArray) 
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


bool FindNumber(int[,] array, int num) 
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j]==num) return true; 
        }
    }
    return false;
}