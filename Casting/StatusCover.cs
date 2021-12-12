using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class StatusC : Actor
  {
    public StatusC()
    {
      SetImage(Constants.IMAGE_BLACK);
      SetHeight(Constants.HERO_HEIGHT);
      SetWidth(Constants.HERO_WIDTH);
      
      
      Point position = new Point(0, 0);
      SetPosition(position);
            

      SetVelocity(new Point(0, 0));
    }
      
  }
}