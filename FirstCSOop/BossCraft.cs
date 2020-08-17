using System;

namespace firstCSOop
{
  class BossCraft : IUFO
  {
    public string COLOR{get;set;}

    public int size{get;set;}

    public void fly()
    {
      Console.WriteLine("{0} BossCraft {1}: Wow flying real fast", COLOR, size);
    }

    public void goToHyperspace()
    {
      Console.WriteLine("BossCraft: WOAHHHH");
    }

    public void land()
    {
      Console.WriteLine("BossCraft: Easy land");
    }
  }
}
