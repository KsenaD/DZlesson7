//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.Write ("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double [,] GetArray(int m, int n)
// {
// double[,] matrix = new double [m,n];
// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j=0; j < matrix.GetLength(1); j++)
//         {
//             matrix [i,j] = Convert.ToDouble(new Random().NextDouble())*Convert.ToDouble(new Random().Next(100));
//         }
//     }
//     return matrix;
// }
// double [,] resultMatrix = GetArray(rows,columns);
// PrintArray (resultMatrix);

// void PrintArray (double [,] inputMatrix)
// {
//     for (int i=0; i<inputMatrix.GetLongLength(0); i++)
//     {
//         for (int j=0; j<inputMatrix.GetLength(1); j++)
//         {
//             Console.Write (Math.Round(inputMatrix[i,j],3) + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int [,]Array=new int [4,4];
// for (int i = 0; i<Array.GetLength (0); i++)
// {
//     for(int j=0; j<Array.GetLength(1); j++)
//     {
//         Array[i,j] = new Random().Next(11);
//         Console.Write(Array[i,j]+"\t");
//     }
//     Console.WriteLine();
// }
// Console.Write ("Введите номер строки в массиве: ");
// int row = Convert.ToInt32(Console.ReadLine());
// if (row<=Array.GetLength(0))
// {
//     Console.Write ("Введите номер столбца в массиве: ");
//     int column = Convert.ToInt32(Console.ReadLine());
//         if (column <=Array.GetLength(1))
//         {
//             Console.WriteLine ($"Значение элемента {row},{column} = {Array[row,column]}");
//         }
//         else 
//         {
//             Console.WriteLine($"Столбца {column} нет в массиве");
//         }
// }
// else 
// {
// Console.WriteLine($"Строки {row} нет в массиве");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write ("Введите количество строк:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите количество столбцов:  ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,]matrix = new int[rows,columns];
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(10);
            Console.Write(matrix[i,j]+ "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    
double avg;
for (int j=0; j<matrix.GetLength(1);j++)
{
   avg = 0;
   for (int i = 0; i<matrix.GetLength(0); i++)
     {
        avg = avg + matrix[i,j];
     }
     Console.Write(Math.Round(avg/matrix.GetLength(0),2)+"\t");
}


