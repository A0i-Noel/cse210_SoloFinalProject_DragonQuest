using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest.Casting
{
  public class Status : Actor
  {
    Hero _hero = new Hero();
        
    string word = "";
    int HP = 10;
    int MP = 0;
    int MaxHP = 10;
    int MaxMP = 0;
    int Mighty = 2;
    int Lv = 1;
    int Exp = 0;

    public Status (Hero hero)
    {
      _hero = hero;
      _position = new Point(0, 0);
      _width = 0;
      _height = 0;
      redText = false;

      UpdateText();
    }

    public void UpdateText()
    {
      HP = _hero.GetHP();
      MP = _hero.GetMP();
      Lv = _hero.GetLevel();
      MaxHP = _hero.GetMAX_HP();
      MaxMP = _hero.GetMAX_MP();
      _text = $"Hero Lv.{Lv}\nHP:{HP}/{MaxHP} MP:{MP}/{MaxMP}";
      Dying();
    }

    public bool Dying()
    {
      if(HP <= MaxHP * 0.3)
      {
        return redText =true;
      }
      return redText = false;
    }
  }
}