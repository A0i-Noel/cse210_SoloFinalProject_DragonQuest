using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class BottonIntro : Actor
  {
    public BottonIntro()
    {
      _position = new Point(0, 770);
      _width = 0;
      _height = 0;
      redText = false;

      DisplayText();
    }

    public void DisplayText()
    {
      _text ="A: Attack & Action S: Heal (MP:3)  D: Frizz(MP:4)";
    }

    
  }
}