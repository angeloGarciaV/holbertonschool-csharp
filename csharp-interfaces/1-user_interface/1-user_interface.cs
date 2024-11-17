using System;

/// <summary>
/// 
/// </summary>
abstract class Base {

    public string name { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString() {
        return $"{name} is a {this.GetType()}";
    }
}

interface IInteractive
{
  void Interact();
}

interface IBreakable
{
  int Durability { get; set; }
  void Break();
}

interface ICollectable
{
  bool isCollected { get; set; }
  void Collect();
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
  public int Durability { get; set; }
  public bool isCollected { get; set; }

  public void Interact()
  {
    // Do something
  }

  public void Break()
  {
    // Do something
  }

  public void Collect()
  {
    // Do something
  }
}