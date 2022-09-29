Console.Clear();
 
 
void InputMatrix(int[,] matrix)
 {
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         matrix[i, j] = new Random().Next(1, 10);
     }
 }
 void PrintMatrix(int[,] matrix)
 {
     Console.WriteLine();
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         Console.Write(matrix[i, j] + " \t");
         Console.WriteLine();
     }
 }
 void Summa(int[,] matrix)
 {int summa =0;
 int minSumma = 1000;
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
             summa += matrix[i, j];    
            Console.WriteLine($"Сумма элементов {i+1} строки " + summa);
        if(summa < minSumma)
            minSumma = summa;
    }
Console.WriteLine("Минимальная сумма " + minSumma);
}


Console.WriteLine("Двумерный массив необходимо задать прямоугольный. Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
if (n ==m)
    Console.WriteLine("Необходимо задать прямоугольный двумерный массив");
else
{
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Summa(matrix);
}

