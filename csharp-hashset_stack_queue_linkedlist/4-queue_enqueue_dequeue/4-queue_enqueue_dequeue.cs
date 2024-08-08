using System;
using System.Collections.Generic;

class MyQueue
{
  public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
  {
    Console.WriteLine($"Number of items: {aQueue.Count}");

    if(aQueue.Count == 0)
    {
      Console.WriteLine("Queue is empty");
    }else
    {
      Console.WriteLine($"First item: {aQueue.Peek()}");
    }
    aQueue.Enqueue(newItem);
    if(aQueue.Contains(search))
    {
      Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");
      while(aQueue.Dequeue() != search);
    }
    return aQueue;
  }
}

// Add a new given item newItem to aQueue
// Print if aQueue contains a given item search
// Format: Queue contains <search>: <True / False>
// If aQueue contains the given item search, remove all items up to and including search; otherwise, leave aQueue as is
// You can use .Dequeue() only once
// Return aQueue