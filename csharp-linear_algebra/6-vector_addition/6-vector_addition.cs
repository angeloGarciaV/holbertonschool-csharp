using System;
using System.Numerics;

class VectorMath
{
  /// <summary>
  /// Adds two vectors
  /// </summary>
  /// <param name="vector1"></param>
  /// <param name="vector2"></param>
  /// <returns>added array of doubles</returns>
  public static double[] Add(double[] vector1, double[] vector2)
  {
    double[] vectorSum = new double[vector1.Length];

    if(vector1.Length != vector2.Length)
      return new double[] {-1};

    if(vector1.Length < 2 || vector2.Length < 2)
      return new double[] {-1};

    for(int i = 0; i < vector1.Length; i++)
    {
      vectorSum[i] = vector1[i] + vector2[i];
    }
    return vectorSum;
  }
}
