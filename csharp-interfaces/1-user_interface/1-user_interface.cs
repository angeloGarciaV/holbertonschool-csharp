using System;

/// <summary>
/// 
/// </summary>
abstract class Base {

    public string name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString() {
        return $"{name} is a {this.GetType()}";
    }

  interface IInteractive{
    void Interact();
  }
  interface IBreakable{
    int Durability{get; set;}
    void Break();
  }
  interface ICollectable{
    bool isCollected{get; set;}
    void Collect();
  }
}

class TestObject : Base, IInteractive, IBreakable, ICollectable{

}