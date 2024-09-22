using System;

/// <summary>
/// Represents a class of matrix operations.
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
    if (cols1 == rows2)
    {
      for(int i =0; i< rows1; i++)
      {
        for(int j = 0; j < cols2; j++)
        {
          sum = 0;
          for(int k = 0; k < cols1; k++)
          {
            sum += matrix1[i,k] * matrix2[k,j];
          }
          result[i,j] = Math.Round(sum, 2);
        }
      }
      return result;
    }
    return new double[,] {{-1}};
  }

  public static double[,] Shear2D(double[,] matrix, char direction, double factor)
  {
    double[,] shear = new double[2,2];

    if(direction == 'X' || direction == 'x')
    {
      shear  = new double[2,2] {{1, factor}, {0, 1}};

    } else if(direction == 'Y' || direction == 'y')
    {
      shear  = new double[2,2] {{1, 0}, {factor, 1}};
    }
    
    matrix = new Double[2,2]{{matrix[0,0], matrix[1,0]},{matrix[0,1], matrix[1,1]}};
    matrix = Multiply(shear, matrix);
    matrix = new Double[2,2]{{matrix[0,0], matrix[1,0]},{matrix[0,1], matrix[1,1]}};
    return matrix;
  }
}