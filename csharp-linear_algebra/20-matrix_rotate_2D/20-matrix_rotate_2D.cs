using System;

class MatrixMath
{
  public static double[,] Rotate2D(double[,] matrix, double angle)
  {
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    double cosAngle = Math.Cos(angle);
    double sinAngle = Math.Sin(angle);
    double sum = 0;
    double[,] rotation = new double[2,2]{{cosAngle, sinAngle}, {-sinAngle, cosAngle}};
    double[,] res = new double[rows,cols];

    for(int i =0; i< rows; i++)
      {
        for(int j = 0; j < rotation.GetLength(1); j++)
        {
          for(int k = 0; k < cols; k++)
          {
            sum += matrix[i,k] * rotation[k,j];
            
          }
          res[i,j] = Math.Round(sum,2);
          sum = 0;
        }
      }
    return res;
  }
}