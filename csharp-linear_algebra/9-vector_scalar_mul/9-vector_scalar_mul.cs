using System;

/// <summary>
/// Represents a class of vector math
/// </summary>
class VectorMath
{
  /// <summary>
  ///  Multiplies a vector by a scalar
  /// </summary>
  /// <param name="vector">vector to multiply</param>
  /// <param name="scalar">scalar to multiply by</param>
  /// <returns>multiplied vector</returns>
  public static double[] Multiply(double[] vector, double scalar)
  {
    if(vector.Length < 2)
      return new double[] {-1};

    double[] newVector = new double[vector.Length];
    for(int i = 0; i< vector.Length; i++)
    {
      newVector[i] = vector[i]*scalar;
    }
    return newVector;
  }
}
