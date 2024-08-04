using System;

class List
{
  public static List<bool> DivisibleBy2(List<int> myList)
  {
    List<bool> evens = new List<bool>();
    for(int i = 0; i < myList.Count; i++)
    {
      if(myList[i] % 2 == 0)
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