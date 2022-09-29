Console.Clear();

void PrintMatrix(int[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write(matr[i, j] + "\t");
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matr)
{
    for (int raws = 0; raws < matr.GetLength(0); raws++)
    {
        for (int cols = 0; cols < matr.GetLength(1); cols++)
            matr[raws, cols] = new Random().Next(0, 101);
    }
}

int[,] newRaws(int[,] matr)
{
    for (int n = 0; n < matr.GetLength(0); n++)
    {
        for (int m = 0; m < matr.GetLength(1) - 1; m++)
        {
            int min = matr[n, m];
            int minM = m;
            for (int nextM = m + 1; nextM < matr.GetLength(1); nextM++)
            {
                if (matr[n, nextM] < min)
                {
                    min = matr[n, nextM];
                    minM = nextM;
                }
            }
            int temp = matr[n, m];
            matr[n, m] = matr[n, minM];
            matr[n, minM] = temp;
        }
    }
    return matr;
}

Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
Console.WriteLine($"Задан двумерный массив размером [{n}, {m}]");

FillMatrix(matrix);
PrintMatrix(matrix);
PrintMatrix(newRaws(matrix));