Console.Clear();

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void ArithmeticMeanCol(int[,] array)
{

            
    for (int j = 0; j < array.GetLength(1); j++)
    { 
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = (sum + array[i,j]);
            
        }
        Console.WriteLine($" Среднне арифметическое {j} столбца равно {Math.Round(sum / array.GetLength(0), 1)}");
    }
    
}




int[,] printArray = FillMatrix(5, 3);
ArithmeticMeanCol(printArray);