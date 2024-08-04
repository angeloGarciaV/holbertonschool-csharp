using System;
using System.Collections.Generic;

class Dictionary
{
  public static string BestScore(Dictionary<string, int> myList)
  {
    if(myList.Values.Count == 0)
    {
      return "None";
    }
    int highest = 0;
    string person = "";
    foreach(KeyValuePair<string, int> kvp in myList)
    {
      if(kvp.Value > highest)
      {
        highest = kvp.Value;
        person = kvp.Key;
      }
    }
    return person;
  }
}


// Class Name: Dictionary
// Prototype: public static string BestScore(Dictionary<string, int> myList)
// Returns the key with the biggest integer value
// You can assume that all values are non-negative integers
// You can assume that all students have a different score
// If no scores are found, return “None”