using System;

namespace firstCSOop
{
  class SmallCraft : IUFO
  {
    public string COLOR{get;set;}
    public int size{get;set;}

    public void fly()
    {
      Console.WriteLine("SmallCraft: We just flying");
    }

    public void goToHyperspace()
    {
      Console.WriteLine("{0} SmallCraft {1}: Can we even jump to hyperspace?", COLOR, size);
    }

    public void land()
    {
      Console.WriteLine("SmallCraft: Rough landing :/");
    }
  }
}
