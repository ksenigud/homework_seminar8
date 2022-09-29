Console.Clear();

int[,] SpiralMatrix(int[,] spiral, int row, int col, int orderNumber)
{
    spiral[row, col] = orderNumber;

    if (row - 1 < 0 || spiral[row - 1, col] != 0)
    {
        if (col + 1 < spiral.GetLength(1) && spiral[row, col + 1] == 0)
            return SpiralMatrix(spiral, row, ++col, ++orderNumber);
    }

    if (row + 1 < spiral.GetLength(0) && spiral[row + 1, col] == 0)
        return SpiralMatrix(spiral, ++row, col, ++orderNumber);

    if (col > 0 && spiral[row, col - 1] == 0)
        return SpiralMatrix(spiral, row, --col, ++orderNumber);

    if (row > 0 && spiral[row - 1, col] == 0)
        return SpiralMatrix(spiral, --row, col, ++orderNumber);

    return spiral;
}

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
Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
PrintMatrix(SpiralMatrix(spiral: matrix, row: 0, col: 0, orderNumber: 1));
