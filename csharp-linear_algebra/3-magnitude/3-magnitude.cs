using System;
using System.Reflection;

  class VectorMath
  {
    /// <summary>
    /// Calculates the length of a vector.
    /// </summary>
    /// <param name="vector">2D or 3D vector.</param>
    /// <returns>Returns the magnitude of a 2D or 3D vector.</returns>
    public static double Magnitude(double[] vector)
    {
      if(vector.Length < 2)
      {
        return -1;
      }
      if(vector.Length == 2)
      {
        double squaredSum = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2);
        return Math.Round(Math.Sqrt(squaredSum), 2);
      }
      if(vector.Length == 3)
      {
        double length = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2));
        return Math.Round(length,2);
      }
      return -1;
    }
  }
