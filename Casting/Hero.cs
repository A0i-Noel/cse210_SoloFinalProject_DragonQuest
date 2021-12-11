using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Hero : Actor
  {
    
    public Hero ()
    {
      SetImage(Constants.IMAGE_HERO);
      SetHeight(Constants.HERO_HEIGHT);
      SetWidth(Constants.HERO_WIDTH);
      SetLevel(1);
      SetHP(15);
      SetMP(0);
      SetMAX_HP(15);
      SetMAX_MP(0);
      SetMighty(2);
      SetEXP(0);
      SetNeedEXP(10, 25, 45, 70, 100, 135, 175, 220, 270, 999);
      

      Point position = new Point(Constants.Screen_X/2 - Constants.HERO_WIDTH/2, Constants.Screen_Y/2 - Constants.HERO_HEIGHT/2);
      SetPosition(position);
            

      SetVelocity(new Point(0, 0));
    }
  }
}