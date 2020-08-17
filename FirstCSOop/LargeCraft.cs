using System;

namespace firstCSOop
{
  class LargeCraft : IUFO
  {

    public string COLOR{get;set;}

    public int size{get;set;}
    public void fly()
    {
      Console.WriteLine("LargeCraft: Wow flying fast");
    }

    public void goToHyperspace()
    {
      Console.WriteLine("{0} LargeCraft {1}: vroom the stars go",COLOR, size);
    }

    public void land()
    {
      Console.WriteLine("LargeCraft: Smooth landing");
    }
  }
}
