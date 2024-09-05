using System;
/// <summary>
/// Represents an object.
/// </summary>
public class Obj
{
  /// <summary>
  /// Determines if a type is only a subclass of another type.
  /// </summary>
  /// <param name="derivedType"></param>
  /// <param name="baseType"></param>
  /// <returns>bool</returns>
  public static bool IsOnlyASubclass(Type derivedType, Type baseType)
  {
    return derivedType != baseType && derivedType.IsSubclassOf(baseType);
  }
}
