using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Hero : Actor
  {
    int HP = 15;
    int MP = 0;
    int Mighty = 2;
    int Lv = 1;
    int Exp = 0;
    public Hero ()
    {
      SetImage(Constants.IMAGE_HERO);
      SetHeight(Constants.HERO_HEIGHT);
      SetWidth(Constants.HERO_WIDTH);
      SetLevel(Lv);
      SetHP(HP);
      SetMP(MP);
      SetMighty(Mighty);
      SetEXP(Exp);
      

      Point position = new Point(Constants.Screen_X/2 - Constants.HERO_WIDTH/2, Constants.Screen_Y/2 - Constants.HERO_HEIGHT/2);
      SetPosition(position);
            

      SetVelocity(new Point(0, 0));
    }
  }
}