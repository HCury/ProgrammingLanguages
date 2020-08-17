using System;

namespace firstCSOop
{
  interface IUFO
  {
    string COLOR{get;set;}
    int size{get;set;}
    void fly();
    void goToHyperspace();
    void land();
  }
}
