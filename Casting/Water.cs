using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Water : Actor
  {
    public Water (int x, int y)
    {
      SetImage(Constants.IMAGE_WATER);
      SetHeight(Constants.MAP_HEIGHT);
      SetWidth(Constants.MAP_WIDTH);
      
      int _x = x;
      int _y = y;
      Point position = new Point(_x, _y);
      SetPosition(position);
            

      SetVelocity(new Point(0, 0));
    }
  }
}