/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Write("Введите количество строк в 1 массиве: ");
int row1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк и столбцов в 1 массиве: ");
int column1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк во 2 массиве: ");
int row2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк и столбцов во 2 массиве: ");
int column2 = Convert.ToInt32(Console.ReadLine());


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

int[,] matrix1 = GetMatrix(row1, column1);
int[,] matrix2 = GetMatrix(row2, column2);
int[,] resultMatrix = new int[row1, column2];

PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);

if (column2 != row1)

{
Console.WriteLine("Произведение матриц нельзя вычислить");
}

else 

{

for (int i = 0; i < row1; i++)

{

    for (int j= 0; j < column2; j++) 

    {
        for (int k= 0; k < row1; k++)
                
             {
                resultMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
             }
                
    }

    
}

Console.WriteLine("Произведение введенных матриц: ");
PrintMatrix(resultMatrix);

}


