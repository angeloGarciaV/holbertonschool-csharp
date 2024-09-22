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
        if (matrix.Length == 0){
            return (new double[,]{});
        }
        var newMatrix = new double[matrix.GetLength(1),matrix.GetLength(0)];
        for (int y = 0; y < matrix.GetLength(0); y++){
            for (int x = 0; x < matrix.GetLength(1); x++){
                newMatrix[x,y] = matrix[y,x];
            }
        }
        return newMatrix;
    }
}