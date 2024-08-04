using System;
using System.Collections.Generic;
using System.Numerics;

class Dictionary
{
  public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
  {
    Dictionary<string, int> newDict = new Dictionary<string, int>();

    foreach (KeyValuePair<string, int> kvp in myDict)
    {
      var k = kvp.Key;
      var v = kvp.Value;
      myDict[k] = v*2;
    }
    return myDict;
  }
}