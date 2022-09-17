/*Задача 60. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/


Console.WriteLine("Выводим спирально матрицу 4х4: ");
int size = 4;
int[,] matrix = new int[size, size];

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

int number = 1;
for (int j = 0; j < size; j++)
    {
    matrix[0,j] = number;
    number++;
    }

for (int i = 1; i < size; i++)
    {
    matrix[i,3] = number;
    number++;
    }

for (int j = 2; j >= 0; j--)
    {
    matrix[3,j] = number;
    number++;
    }

for (int i = 2; i > 0; i--)
    {
    matrix[i,0] = number;
    number++;
    }
for (int j = 1; j < 3; j++)
    {
    matrix[1,j] = number;
    number++;
    }
matrix[2,2] = 15;
matrix[2,1] = 16;

PrintMatrix(matrix);