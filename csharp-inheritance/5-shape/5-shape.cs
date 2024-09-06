using System;
/// <summary>
/// Represents a shape.
/// </summary>
class Shape
{
  /// <summary>
  /// Calculates the area of the shape.
  /// </summary>
  /// <returns>int</returns>
  public virtual int Area()
  {
    throw new NotImplementedException("Area() is not implemented");
  }
}