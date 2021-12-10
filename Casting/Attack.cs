using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Services;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Attack : Actor
  {


    public Attack ()
    {

  

      SetImage(Constants.IMAGE_ATTACK);
      SetHeight(Constants.ATTACK_HEIGHT);
      SetWidth(Constants.ATTACK_WIDTH);

      Point position = new Point(Constants.Screen_X/2 - Constants.HERO_WIDTH/2, Constants.Screen_Y/2 - Constants.HERO_HEIGHT/2);
      SetPosition(position);
         

      SetVelocity(new Point(0, 0));
    }
  }
}