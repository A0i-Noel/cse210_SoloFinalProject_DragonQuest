using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Board : Monsters
  {

    public Board (int x, int y)
    {
      SetImage(Constants.IMAGE_BOARD);
      SetHeight(Constants.SLIME_HEIGHT);
      SetWidth(Constants.SLIME_WIDTH);
      SetText(Constants.TEXT_INTRO);
    

      int _x = x;
      int _y = y;
      Point position = new Point(_x, _y);
      SetPosition(position);
            

      SetVelocity(new Point(0, 0));
    }
  }
}