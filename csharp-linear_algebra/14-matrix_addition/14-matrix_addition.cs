using System;

class MatrixMath
{
  public static double[,] Add(double[,] matrix1, double[,] matrix2)
  {
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);
    double[,] result = new double[rows1, cols1];
    double[,] rtrn = { { -1 } };

    if (rows1 != rows2 || cols1 != cols2)
      return rtrn;

    for(int k = 0; k < rows1; k++ )
    {
      if(matrix1.GetLength(1) != cols1 || matrix2.GetLength(1) != cols2)
        return rtrn;
    }

  for(int i =0; i< rows1; i++)
    {
      for(int j = 0; j < cols1; j++)
      {
        result[i,j] = matrix1[i,j] + matrix2[i,j];
      }
    }
    return result;
  }
}

// Create a method that adds two matrices and returns the resulting matrix.

// Class: MatrixMath
// Prototype: public static double[,] Add(double[,] matrix1, double[,] matrix2)
// The matrices can be either both 2D or both 3D
// 2D ex.: double[,] matrix = { { 1, 2 }, { 3, 4 } };
// 3D ex.: double[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
// If acols2 matrix is not a 2D or 3D matrix, or both matrices are not the same size, return a matrix containing -1