/*
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

double[,] InitMatrix()
{
    double[,] matrix = new double[3,4];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = rnd.Next(1,20);
                }
        }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
            Console.WriteLine();
        }       
}

void Average(double[,] matrix)
{
    double[] array = new double[4];

    array[0] = (matrix[0,0] + matrix[1,0] + matrix[2,0]) /3;
    array[1] = (matrix[0,1] + matrix[1,1] + matrix[2,1]) /3;
    array[2] = (matrix[0,2] + matrix[1,2] + matrix[2,2]) /3;
    array[3] = (matrix[0,3] + matrix[1,3] + matrix[2,3]) /3;
    
    Console.WriteLine($"Среднее арифметическое первого столбца массива = {Math.Round(array[0], 1)}");
    Console.WriteLine($"Среднее арифметическое второго столбца массива = {Math.Round(array[1], 1)}");
    Console.WriteLine($"Среднее арифметическое третьего столбца массива = {Math.Round(array[2], 1)}");
    Console.WriteLine($"Среднее арифметическое четвертого столбца массива = {Math.Round(array[3], 1)}"); 
}


double[,] matrix = InitMatrix();
PrintMatrix(matrix);
Average(matrix);
