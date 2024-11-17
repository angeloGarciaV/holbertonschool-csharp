using System;

/// <summary>
/// Base class
/// </summary>
abstract class Base {

    public string name { get; set; } = string.Empty;

    /// <summary>
    /// Override ToString method
    /// </summary>
    /// <returns></returns>
    public override string ToString() {
        return $"{name} is a {this.GetType()}";
    }
}
/// <summary>
/// Interactive interface
/// </summary>
interface IInteractive
{
  void Interact();
}
/// <summary>
/// Breakable interface
/// </summary>
interface IBreakable
{
  int Durability { get; set; }
  void Break();
}
/// <summary>
/// Collectable interface
/// </summary>
interface ICollectable
{
  bool isCollected { get; set; }
  void Collect();
}
/// <summary>
/// TestObject class
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
  public int Durability { get; set; }
  public bool isCollected { get; set; }

  public void Interact()
  {
    throw new NotImplementedException();
  }

  public void Break()
  {
    throw new NotImplementedException();

  }

  public void Collect()
  {
    throw new NotImplementedException();
  }
}