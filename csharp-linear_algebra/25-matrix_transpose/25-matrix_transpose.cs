using System;

/// <summary>
/// Represents a class of matrix operations.
/// </summary>
class MatrixMath
{
  /// <summary>
  /// Represents a method to transpose a matrix.
  /// </summary>
  /// <param name="matrix">The matrix to transpose.</param>
  /// <returns>The transposed matrix.</returns>
  public static double[,] Transpose(double[,] matrix)
  {
    if (matrix.Length == 0)
    {
      return new double[,] {{}};
    }
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    double[,] result = new double[cols, rows];
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < cols; j++)
      {
        result[j, i] = matrix[i, j];
      }
    }
    return result;
  }
}