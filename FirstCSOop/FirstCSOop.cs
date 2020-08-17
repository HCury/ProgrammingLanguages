using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static firstCSOop.Animal;

namespace firstCSOop
{
  class firstCSOop
  {
    static void Main(string[] args)
    {
      Dog dog = new Dog();
      Cat cat = new Cat();
      Bird bird = new Bird();
      SmallCraft sm = new SmallCraft();
      LargeCraft lg = new LargeCraft();
      BossCraft boss = new BossCraft();


      dog.sing();
      dog.wash();
      dog.turnAround();
      dog.move();
      dog.sleep();
      dog.eat();

      cat.sing();
      cat.wash();
      cat.turnAround();
      cat.move();
      cat.sleep();
      cat.eat();

      bird.sing();
      bird.wash();
      bird.turnAround();
      bird.move();
      bird.sleep();
      bird.eat();

      sm.COLOR = "BLUE";
      sm.size = 500;
      sm.fly();
      sm.goToHyperspace();
      sm.land();

      lg.COLOR = "YELLOW";
      lg.size = 1000;
      lg.fly();
      lg.goToHyperspace();
      lg.land();

      boss.COLOR = "RED";
      boss.size = 1500;
      boss.fly();
      boss.goToHyperspace();
      boss.land();
    }
  }
}
