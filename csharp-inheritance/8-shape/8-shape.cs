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

/// <summary>
/// Represents a Rectangle.
/// </summary>
class Rectangle : Shape
{
  private int width;
  private int height;

  public int Width
    {
      get {return width;}
      set {
        if (value < 0)
        throw new ArgumentException("Width must be greater than or equal to 0");

        width = value;
      }
    }
  public int Height
    {
      get {return height;}
      set {
        if (value < 0)
        throw new ArgumentException("Height must be greater than or equal to 0");

        height = value;
      }
    }

  /// <summary>
  /// Calculates the area of the rectangle.
  /// </summary>
  /// <returns>int</returns>
  public new int Area()
  {
    return width * height;
  }

  /// <summary>
  /// Returns the string representation of the rectangle.
  /// </summary>
  /// <returns>string</returns>
  public override string ToString()
  {
    return ($"[Rectangle] {width} / {height}");
  }
}

/// <summary>
/// Represents a Square.
/// </summary>
class Square : Rectangle
{
  private int size;

  public int Size
  {
    get {return size;}
    set
    {
      if(value < 0)
        throw new ArgumentException("Size must be greater than or equal to 0");

      size = value;
      Width = value;
      Height = value;
    }
  }
}