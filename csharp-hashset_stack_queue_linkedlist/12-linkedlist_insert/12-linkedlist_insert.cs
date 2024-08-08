using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = myLList.First, last = null;

        while (newNode != null)
        {
            if (newNode.Value >= n && last.Value < n)
                return myLList.AddBefore(newNode, n);
            last = newNode;
            newNode = newNode.Next;
        }
        return myLList.AddLast(n);
    }
}