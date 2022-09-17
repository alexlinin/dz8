/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка*/

Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк и столбцов в массиве: ");
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

PrintMatrix(resultMatrix);

int minIndex = 0;
int index = 0;
int maxsum = 0;

for (int i = 0; i < row; i++)

{
    int sum = 0;

    for (int j = 0; j < column; j++) 
    
    {
        sum += resultMatrix[i, j];
    }
    
    if (i == 0)
    {
        maxsum = sum;
    }

    if (sum < maxsum)

    {
        maxsum = sum;
        minIndex = i;
    }

}

Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {minIndex} ");

