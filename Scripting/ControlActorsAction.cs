using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;
using cse210_FinalProject_DragonQuest.Services;
using System;

namespace cse210_FinalProject_DragonQuest.Scripting
{
  public class ControlActorsAction : Action
  {
    InputService _inputService;
    
    

    public ControlActorsAction(InputService inputService)
    {
      _inputService = inputService;
    }

    public override void Execute(Dictionary<string, List<Actor>> cast)
    {
      Point direction = _inputService.GetDirection();
      Point stop = new Point(0, 0);
      bool APress = _inputService.IsAPressed();
      bool SPress = _inputService.IsSPressed();
      bool DPress = _inputService.IsDPressed();

      int cField = 0;
      int cDesert = 0;
      int cTree = 0;
      int cWater = 0;
      int cSea = 0;
      int csMountain = 0;
      int chMountain = 0;

      Actor hero = cast["Hero"][0];

      

      List<Actor> Fields = cast["Field"];
      foreach(Actor m in Fields)
      {
        cField += 1;
      }

      List<Actor> Deserts = cast["Desert"];
      foreach(Actor m in Deserts)
      {
        cDesert += 1;
      }

      List<Actor> Trees = cast["Tree"];
      foreach(Actor m in Trees)
      {
        cTree += 1;
      }

      List<Actor> Seas = cast["Sea"];
      foreach(Actor m in Seas)
      {
        cSea += 1;
      }

      List<Actor> Waters = cast["Water"];
      foreach(Actor m in Waters)
      {
        cWater += 1;
      }

      List<Actor> sMountains = cast["sMountain"];
      foreach(Actor m in sMountains)
      {
        csMountain += 1;
      }

      List<Actor> hMountains = cast["hMountain"];
      foreach(Actor m in hMountains)
      {
        chMountain += 1;
      }

      

      

        for(int i =0;i < cField; i++ )
        {
          Actor field = cast["Field"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED);
          field.SetVelocity(Svelocity);
          
        }

        for(int i =0;i < cDesert; i++ )
        {
          Actor desert = cast["Desert"][i];
           Point Svelocity = direction.Scale(Constants.MAP_SPEED);
          desert.SetVelocity(Svelocity);
        }

        for(int i =0;i < chMountain; i++ )
        {
          Actor hMountain = cast["hMountain"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED);
          hMountain.SetVelocity(Svelocity);
        }

        for(int i =0;i < csMountain; i++ )
        {
          Actor sMountain = cast["sMountain"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED);
          sMountain.SetVelocity(Svelocity);
        }

        for(int i =0;i < cTree; i++ )
        {
          Actor Tree = cast["Tree"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED);
          Tree.SetVelocity(Svelocity);
        }

        for(int i =0;i < cWater; i++ )
        {
          Actor Water = cast["Water"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED);
          Water.SetVelocity(Svelocity);
        }

        for(int i =0;i < cSea; i++ )
        {
          Actor Sea = cast["Sea"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED);
          Sea.SetVelocity(Svelocity);
        }

        for(int i =0;i <= Constants.SLIME_MAX_NUMBER; i++ )
        {
          Actor slime = cast["Slime"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED);
          slime.SetVelocity(Svelocity);
        }

        for(int i =0;i <= Constants.DRAKEE_MAX_NUMBER; i++ )
        {
          Actor drakee = cast["Drakee"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED);
          drakee.SetVelocity(Svelocity);
        }

        for(int i = 0; i < 1;i++){
          Actor dragon = cast["Dragon"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED);
          dragon.SetVelocity(Svelocity);
        }
        
      

      Actor attack = cast["Attack"][0];
      if(_inputService.IsDownPressed())
      {
        Point position = new Point(Constants.Screen_X/2 - Constants.HERO_WIDTH/2, Constants.Screen_Y/2 - Constants.HERO_HEIGHT/2 + Constants.ATTACK_HEIGHT);
        attack.SetPosition(position);
      }

      if(_inputService.IsUpPressed())
      {
        Point position = new Point(Constants.Screen_X/2 - Constants.HERO_WIDTH/2, Constants.Screen_Y/2 - Constants.HERO_HEIGHT/2 - Constants.ATTACK_HEIGHT);
        attack.SetPosition(position);
      }

      if(_inputService.IsRightPressed())
      {
        Point position = new Point(Constants.Screen_X/2 - Constants.HERO_WIDTH/2 + Constants.ATTACK_WIDTH, Constants.Screen_Y/2 - Constants.HERO_HEIGHT/2);
        attack.SetPosition(position);
      }

      if(_inputService.IsLeftPressed())
      {
        Point position = new Point(Constants.Screen_X/2 - Constants.HERO_WIDTH/2 - Constants.ATTACK_WIDTH, Constants.Screen_Y/2 - Constants.HERO_HEIGHT/2);
        attack.SetPosition(position);
      }

      
    }

    


   
  }
  
}