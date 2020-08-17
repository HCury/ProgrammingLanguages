using System;

namespace firstCSOop
{
  class Bird : Animal
  {
    public void sing()
    {
      Console.WriteLine("Bird: Chirp chirp.");
    }

    public void wash()
    {
      Console.WriteLine("Bird: Ooo a fountain");
    }

    public void turnAround()
    {
      Console.WriteLine("Bird: Swift 180.");
    }
  }
}
