using System;
using System.Collections.Generic;

class Dictionary
{
  public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
  {
    foreach (KeyValuePair<string, int> kvp in myDict)
    {
      var k = kvp.Key;
      var v = kvp.Value;
      myDict[k] = v*2;
    }
    return myDict;
  }
}