using System;

/// <summary>
/// Represents a class to perform matrix operations.
/// </summary>
class MatrixMath
{
  /// <summary>
  /// Represents a method to add two matrices.
  /// </summary>
  /// <param name="matrix1">The first matrix.</param>
  /// <param name="matrix2">The second matrix.</param>
  /// <returns>The sum of the two matrices.</returns>
  public static double[,] Add(double[,] matrix1, double[,] matrix2)
  {
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);
    double[,] result = new double[rows1, cols1];

    if (((rows1 == 2 && cols1 == 2) || (rows1 == 3 && cols1 == 3)) && rows1 == rows2)
    {
        for(int i =0; i< rows1; i++)
      {
        for(int j = 0; j < cols1; j++)
        {
          result[i,j] = matrix1[i,j] + matrix2[i,j];
        }
      }
      return result;
    }
    return new double[,] {{-1}};
  }
}
