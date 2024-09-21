using System;

class MatrixMath
{
  public static double[,] Rotate2D(double[,] matrix, double angle)
  {
    double cos = Math.Cos(angle);
    double sin = Math.Sin(angle);
    double[,] rotation ={{cos,-sin}, {sin, cos}};
    double[,] res = new double[2, 2];
    
    for(int i =0; i< 2; i++)
      {
        for(int j = 0; j < 2; j++)
        {
          for(int k = 0; k < 2; k++)
          {
            res[i,j] += matrix[i,k] * rotation[k,j];
            res[i,j] = Math.Round(res[i,j], 2);
          }
        }
      }

    return res;
  }
}