using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Slime : Monsters
  {
    public Slime (int x, int y)
    {
      SetImage(Constants.IMAGE_SLIME);
      SetHeight(Constants.SLIME_HEIGHT);
      SetWidth(Constants.SLIME_WIDTH);

      int _x = x;
      int _y = y;
      Point position = new Point(_x, _y);
      SetPosition(position);
            

      SetVelocity(new Point(0, 0));
    }
  }
}