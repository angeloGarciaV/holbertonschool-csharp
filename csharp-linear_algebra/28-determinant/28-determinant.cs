using System;

/// <summary>
/// Represents a class of matrix operations.
/// </summary>
class MatrixMath
{
  /// <summary>
  /// Represents a method to calculate the determinant of a matrix.
  /// </summary>
  /// <param name="matrix">The matrix to calculate the determinant of.</param>
  /// <returns>The determinant of the matrix.</returns>
  public static double Determinant(double[,] matrix)
  {
    if (matrix.Length == 0)
    {
      return 1;
    }
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
      throw new ArgumentException("Matrix must be square.");
    }
    if (matrix.GetLength(0) == 1)
    {
      return matrix[0, 0];
    }
    if (matrix.GetLength(0) == 2)
    {
      return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }
    double det = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      double[,] subMatrix = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
      for (int y = 1; y < matrix.GetLength(0); y++)
      {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
          if (x < i)
          {
            subMatrix[y - 1, x] = matrix[y, x];
          }
          else if (x > i)
          {
            subMatrix[y - 1, x - 1] = matrix[y, x];
          }
        }
      }
      det += (i % 2 == 0 ? 1 : -1) * matrix[0, i] * Determinant(subMatrix);
    }
    return det;
  }
}