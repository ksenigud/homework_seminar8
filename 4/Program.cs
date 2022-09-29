 void InputMatrix(int[,,] matrix)
{
 for (int i = 0; i < matrix.GetLength(0); i++)
    {
 for (int j = 0; j < matrix.GetLength(1); j++)
        {
 for (int k = 0; k < matrix.GetLength(2); k++)
 matrix[i, j, k] = new Random().Next(10, 100);
        }
    }
}

 void PrintMatrix(int[,,] matrix)
 {
     Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             for (int k = 0; k < matrix.GetLength(2); k++)
             Console.Write(matrix[i, j, k] + $"({i}, {j}, {k})"  + " \t");
             Console.WriteLine();
         }
   }
}


int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int k = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[n, m, k];
InputMatrix(matrix);
PrintMatrix(matrix);