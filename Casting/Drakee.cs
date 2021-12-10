using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Drakee : Monsters
  {
 
    public Drakee (int x, int y)
    {
      SetImage(Constants.IMAGE_DRAKEE);
      SetHeight(Constants.DRAKEE_HEIGHT);
      SetWidth(Constants.DRAKEE_WIDTH);
      SetHP(10);
      SetMP(100);
      SetMighty(2);
      SetEXP(3);
      int _x = x;
      int _y = y;
      Point position = new Point(_x, _y);
      SetPosition(position);
            

      SetVelocity(new Point(0, 0));
    }
  }
}