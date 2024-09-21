using System;

/// <summary>
/// Represents a class to perform matrix operations.
/// </summary>
class MatrixMath
{
  /// <summary>
  /// Represents a method to multiply a matrix by a scalar.
  /// </summary>
  /// <param name="matrix">The matrix to multiply.</param>
  /// <param name="scalar">The scalar to multiply by.</param>
  /// <returns>The product of the matrix and the scalar.</returns>
  public static double[,] MultiplyScalar(double[,] matrix, double scalar)
  {
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    
    if ((rows == 2 && cols == 2) || (rows == 3 && cols == 3))
    {
      for(int i = 0; i < rows; i++)
      {
        for(int j = 0; j < cols; j++)
        {
          matrix[i,j] *= scalar;
        }
      }
      return matrix;
    }
    return new double[,] {{-1}};
  }
}