using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Dragon : Monsters
  {
    int HP = 150;
    int MP = 150;
    int Mighty = 20;
    int Lv = 1;
    int Exp = 100;
    public Dragon (int x, int y)
    {
      SetImage(Constants.IMAGE_DRAGON);
      SetHeight(Constants.DRAGON_HEIGHT);
      SetWidth(Constants.DRAGON_WIDTH);
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