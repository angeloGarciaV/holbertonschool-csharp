﻿using System;
using System.Collections.Generic;

class LList
{
  public static int GetNode(LinkedList<int> myLList, int n)
  {
    if(n > myLList.Count || n < 0)
    {
      return 0;
    }
LinkedListNode<int> currentNode = myLList.First;
    for(int i = 0; i< n; i++)
    {
      currentNode = currentNode.Next;
    }
    return currentNode.Value;
  }
}