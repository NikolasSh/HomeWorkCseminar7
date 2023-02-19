/*
Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result ) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено неверное число! Повторите ввод!");
        }
    }

    return result;
}

int[,] InitMatrix()
{
    int[,] matrix = new int[3,4];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = rnd.Next(1,50);
                }
        }

    return matrix;
}

void PrintMatrix(int[,] matrix)
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

void FindNumber(int[,] matrix)
{
    int result = GetNumber("Введите число: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == result)
            {
                Console.WriteLine($"Число {result} есть в массиве!");
                return;                
            }
            
            
        }
    }

    Console.WriteLine($"Числа {result} нет в массиве!");
}


int[,] matrix = InitMatrix();
PrintMatrix(matrix);
FindNumber(matrix);