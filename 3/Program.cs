Console.Clear();

Console.WriteLine("Введите количество строк первого двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первого двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int [n, m];
Console.WriteLine("Введите количество строк второго двумерного массива: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второго двумерного массива: ");
int t = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int [n, m];

int[,] matrix3 = new int [n,m];


void InputMatrix(int[,] matrix1)
 {
     for (int i = 0; i < matrix1.GetLength(0); i++)
     {
         for (int j = 0; j < matrix1.GetLength(1); j++)
         matrix1[i, j] = new Random().Next(1, 10);
     }
 }

 
void PrintMatrix(int[,] matrix1)
 {
     Console.WriteLine();
     for (int i = 0; i < matrix1.GetLength(0); i++)
     {
         for (int j = 0; j < matrix1.GetLength(1); j++)
         Console.Write(matrix1[i, j] + " \t");
         Console.WriteLine();
     }
 }


void NewMatrix(int[,] matrix1, int[,] matrix2)
 {
  for (int i = 0; i < matrix1.GetLength(0); i++)
     {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        matrix3[i, j] = matrix1[i, j] * matrix2[i, j];
        
     }   
}

InputMatrix(matrix1);
PrintMatrix(matrix1);
InputMatrix(matrix2);
PrintMatrix(matrix2);
NewMatrix(matrix1, matrix2);
PrintMatrix(matrix3);
