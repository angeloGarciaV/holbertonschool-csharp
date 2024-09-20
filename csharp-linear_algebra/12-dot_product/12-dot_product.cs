using System;
using System.Reflection;

/// <summary>
///  Represents a class to perform vector operations.
/// </summary>
class VectorMath
{
  /// <summary>
  /// Represents a method to calculate the dot product of two vectors.
  /// </summary>
  /// <param name="vector1">The first vector.</param>
  /// <param name="vector2">The second vector.</param>
  /// <returns>The dot product of the two vectors.</returns>
  public static double DotProduct(double[] vector1, double[] vector2)
  {
    if (vector1.Length != 2 && vector1.Length != 3)
            return -1;

    double result = 0;
    for (int i = 0; i < vector1.Length; i++)
    {
      result += vector1[i] * vector2[i];
    }
    return result;
  }
}