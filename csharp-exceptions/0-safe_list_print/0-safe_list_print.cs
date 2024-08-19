using System;
using System.Collections.Generic;

class List
{
  public static int SafePrint(List<int> myList, int n)
  {
    int num = 0;
    try
    {
      for (int i = 0; i < n; i++)
      {
        Console.WriteLine(myList[i]);
        num++;
      }
    }
    catch (Exception e)
    {
      return num;
    }
    return num;
  }
}


// Class Name: List
// Prototype: public static int SafePrint(List<int> myList, int n)
// n represents the number of elements to print
// n can be bigger than the length of myList
// Returns number of elements actually printed
// You have to use try / catch