using System;

/// <summary>
/// Represents object class
/// </summary>
class Obj
{
  /// <summary>
  /// Checks if the object is of type int
  /// </summary>
  public static bool IsOfTypeInt(object obj)
  {
    return obj is int;
  }
}
