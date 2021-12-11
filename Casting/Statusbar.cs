using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Status : Actor
  {
        
    string word = "";
    int HP = 10;
    int MP = 0;
    int MaxHP = 10;
    int MaxMP = 0;
    int Mighty = 2;
    int Lv = 1;
    int Exp = 0;

    public Status ()
    {
      _position = new Point(0, 0);
      _width = 0;
      _height = 0;

      UpdateText();
    }

    public void UpdateText()
    {
      HP = hero.GetHP();
      MP = hero.GetMP();
      Lv = hero.GetLevel();
      MaxHP = hero.GetMAX_HP();
      MaxMP = hero.GetMAX_MP();
      _text = $"Hero Lv.{Lv}\nHP:{HP}/{MaxHP} MP:{MP}/{MaxMP}";
    }

    public bool Dying()
    {
      return HP <= MaxHP * 0.3;
    }
  }
}