/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        
        for (int j = 0; j < n; j++) 
        {
            
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); 
        }
        Console.WriteLine();
    }
}


int[,] resultMatrix = GetMatrix(row, column);

Console.WriteLine("Исходная матрица:");
PrintMatrix(resultMatrix);

for (int i = 0; i < row; i++) 

    {
        
        for (int j = 0; j < column; j++) 

        {

        int maxIndex = j;
        int max = resultMatrix[i, j];

            for (int k = j; k < column; k++)
            {
            if (resultMatrix[i, k] > max)
            {
                max = resultMatrix[i, k];
                maxIndex = k;
            }
            }
            int temp = resultMatrix[i, j];
            resultMatrix[i, j] = resultMatrix[i, maxIndex];
            resultMatrix[i, maxIndex] = temp;

        }
        
    }

Console.WriteLine("Отсортированная матрица");
PrintMatrix(resultMatrix);
