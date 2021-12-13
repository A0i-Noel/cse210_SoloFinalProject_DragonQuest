using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Intro : Monsters
  {

    public Intro ()
    {
      SetText("Hero, defeat the dragon\nhidden in the southeast.");
      
    

      
      Point position = new Point(365, -3);
      SetPosition(position);
            

      SetVelocity(new Point(0, 0));
    }
  }
}