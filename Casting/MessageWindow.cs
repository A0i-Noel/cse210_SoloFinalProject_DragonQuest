using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Message : Monsters
  {

    public Message ()
    {
      SetImage(Constants.IMAGE_WINDOW);
      SetHeight(Constants.SLIME_HEIGHT);
      SetWidth(Constants.SLIME_WIDTH);
      
    

      
      Point position = new Point(304, -5);
      SetPosition(position);
            

      SetVelocity(new Point(0, 0));
    }
  }
}