using System;
using System.Numerics;

/// <summary>
/// Represents a class of vector math
/// </summary>
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
    if ((vector1.Length == 2 || vector1.Length == 3) && vector1.Length == vector2.Length)
        {
            for (int i = 0; i < vector1.Length; i++)
                vector1[i] += vector2[i];
            return vector1;
        }
        return new double[] {-1};
  }
}
