using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Slime : Monsters
  {
    int HP = 10;
    int MP = 0;
    int Mighty = 1;
    int Lv = 1;
    int Exp = 1;
    public Slime (int x, int y)
    {
      SetImage(Constants.IMAGE_SLIME);
      SetHeight(Constants.SLIME_HEIGHT);
      SetWidth(Constants.SLIME_WIDTH);
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