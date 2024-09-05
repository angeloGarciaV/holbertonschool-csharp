using System;
using System.Collections.Generic;

/// <summary>
/// Represents class Obj
/// </summary>
public class Obj
{
  /// <summary>
  ///  Check if an object is an instance of an array
  /// </summary>
  /// <param name="obj">object</param>
  /// <returns>bool</returns>
  public static bool IsInstanceOfArray(object obj)
  {
    if(obj is Array || obj.GetType() == typeof(Array))
    {
      return true;
    }else{
      return false;
    }
  }
}