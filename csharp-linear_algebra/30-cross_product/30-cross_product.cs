using System;

/// <summary>
/// VectorMath main class.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that calculates the cross product of two 3D vectors.
    /// </summary>
    /// <param name="vector1">3D vector</param>
    /// <param name="vector2">3D vector</param>
    /// <returns>Returns the resulting vector.</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2){
        if (vector1.Length != 3 || vector2.Length != 3){
            return (new double[]{-1});
        }
        double i = Math.Round((vector1[1] * vector2[2]) - (vector1[2] * vector2[1]), 2);
        double j = Math.Round((vector1[2] * vector2[0]) - (vector1[0] * vector2[2]), 2);
        double k = Math.Round((vector1[0] * vector2[1]) - (vector1[1] * vector2[0]), 2);
        var resVector = new double[]{i, j, k};
        return resVector;
    }
}