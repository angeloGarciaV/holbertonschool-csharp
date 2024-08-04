using System;
using System.Globalization;

class List
{
  public static List<bool> DivisibleBy2(List<int> myList)
  {
    List<bool> evens = new List<bool>();

    if(myList.Count == 0){
      return evens;
    }
    foreach(int num in myList)
    {
      if(num % 2 == 0)
      {
        evens.Add(true); 
      } else
      {
        evens.Add(false);
      }
    }
    return evens;
  }
}