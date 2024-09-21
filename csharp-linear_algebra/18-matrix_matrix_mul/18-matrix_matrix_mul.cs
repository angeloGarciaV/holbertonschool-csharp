using System;
/// <summary>
/// Represents a class to perform matrix operations.
/// </summary>
class MatrixMath
{
  /// <summary>
  /// Represents a method to multiply two matrices.
  /// </summary>
  /// <param name="matrix1">The first matrix to multiply.</param>
  /// <param name="matrix2">The second matrix to multiply.</param>
  /// <returns>The product of the two matrices.</returns>
  public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
  {
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);
    double[,] result = new double[rows1, cols2]; 
    double sum = 0;

    if (((rows1 == 2 && cols1 == 2) || (rows1 == 3 && cols1 == 3)) && (cols1 == rows2))
    {
      for(int i =0; i< rows1; i++)
      {
        for(int j = 0; j < cols2; j++)
        {
          for(int k = 0; k < cols1; k++)
          {
            sum += matrix1[i,k] * matrix2[k,j];
            
          }
          result[i,j] = sum;
          sum = 0;
        }
      }
      return result;
    }
    return new double[,] {{-1}};
  }
}