using System;
using System.Runtime.CompilerServices;

/// <summary>
/// Queue class
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>{

  public Node head { get; set; } = null;
  public Node tail { get; set; } = null;
  int count { get; set; } = 0;

  /// <summary>
  /// CheckType method
  /// </summary>
  /// <returns>Type</returns>
  public Type CheckType(){
    return typeof(T);
  }

  /// <summary>
  /// Node class
  /// </summary>
  public class Node{
    T value;
    public Node next { get; set;} = null;

    public Node(T _value){
      this.value = _value;
    }
  }
  /// <summary>
  ///  Enqueue method
  /// </summary>
  public void Enqueue(T _value){
    Node newNode = new Node(_value);
    if(head == null){
      head = newNode;
      tail = newNode;
    }else{
      tail.next = newNode;
      tail = newNode;
    }
    count++;
  }

  public int Count(){
    return count;
  }
  
}