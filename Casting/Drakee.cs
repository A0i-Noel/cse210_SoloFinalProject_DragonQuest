using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Drakee : Monsters
  {
    int HP = 10;
    int MP = 100;
    int Mighty = 0;
    int Lv = 1;
    int Exp = 3;
    public Drakee (int x, int y)
    {
      SetImage(Constants.IMAGE_DRAKEE);
      SetHeight(Constants.DRAKEE_HEIGHT);
      SetWidth(Constants.DRAKEE_WIDTH);
      SetHP(HP);
      SetMP(MP);
      SetMighty(Mighty);
      SetEXP(Exp);
      int _x = x;
      int _y = y;
      Point position = new Point(_x, _y);
      SetPosition(position);
            

      SetVelocity(new Point(0, 0));
    }
  }
}