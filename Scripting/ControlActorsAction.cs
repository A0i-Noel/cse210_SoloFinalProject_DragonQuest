using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;
using cse210_FinalProject_DragonQuest.Services;
using System;

namespace cse210_FinalProject_DragonQuest.Scripting
{
  public class ControlActorsAction : Action
  {
    InputService _inputService;
    PhysicsService _physicsService;
    bool wall = true;
    int wallCheck = 0;
    

    public ControlActorsAction(InputService inputService, PhysicsService physicsService)
    {
      _inputService = inputService;
      _physicsService = physicsService;
    }

    public override void Execute(Dictionary<string, List<Actor>> cast)
    {
      Point direction = _inputService.GetDirection();
      Point stop = new Point(0, 0);
      
      bool APress = _inputService.IsAPressed();
      bool SPress = _inputService.IsSPressed();
      bool DPress = _inputService.IsDPressed();

      int cField = 0;
      // int cTree = 0;
      int cWater = 0;
      // int cSea = 0;
      // int chMountain = 0;
      int cWall = 0;

      Actor hero = cast["Hero"][0];

      

      List<Actor> Fields = cast["Field"];
      foreach(Actor m in Fields)
      {
        cField += 1;
      }


      List<Actor> Walls = cast["Wall"];
      foreach(Actor m in Walls)
      {
        cWall += 1;
      }

      List<Actor> Waters = cast["Water"];
      foreach(Actor m in Waters)
      {
        cWater += 1;
      }

      foreach(Actor wall in Walls)
      {
        if(_physicsService.IsCollision(hero, wall))
        {
          wallCheck += 1;
        }
      }

        for(int i =0;i < cField; i++ )
        {
          Actor field = cast["Field"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED); 
          if(wallCheck >= 1)
          {
            

            if(_inputService.IsDownPressed())
          {
            Svelocity = new Point(0, -18);
           
          }

          if(_inputService.IsUpPressed())
          {
            Svelocity = new Point(0, 18);
          }

          if(_inputService.IsRightPressed())
          {
            Svelocity = new Point(-18, 0);
          }

          if(_inputService.IsLeftPressed())
          {
            Svelocity = new Point(18, 0);
          }

          }
          
          field.SetVelocity(Svelocity);
          
          
        }


        for(int i =0;i < cWater; i++ )
        {
          Actor Water = cast["Water"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED); 
          if(wallCheck >= 1)
          {
            

            if(_inputService.IsDownPressed())
          {
            Svelocity = new Point(0, -18);
           
          }

          if(_inputService.IsUpPressed())
          {
            Svelocity = new Point(0, 18);
          }

          if(_inputService.IsRightPressed())
          {
            Svelocity = new Point(-18, 0);
          }

          if(_inputService.IsLeftPressed())
          {
            Svelocity = new Point(18, 0);
          }

          }
          Water.SetVelocity(Svelocity);
        }

        for(int i =0;i < cWall; i++ )
        {
          Actor Wall = cast["Wall"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED); 
          if(wallCheck >= 1)
          {
            

            if(_inputService.IsDownPressed())
          {
            Svelocity = new Point(0, -18);
           
          }

          if(_inputService.IsUpPressed())
          {
            Svelocity = new Point(0, 18);
          }

          if(_inputService.IsRightPressed())
          {
            Svelocity = new Point(-18, 0);
          }

          if(_inputService.IsLeftPressed())
          {
            Svelocity = new Point(18, 0);
          }

          }
          Wall.SetVelocity(Svelocity);
        }

        for(int i =0;i <= Constants.SLIME_MAX_NUMBER; i++ )
        {
          Actor slime = cast["Slime"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED); 
          if(wallCheck >= 1)
          {
            

            if(_inputService.IsDownPressed())
          {
            Svelocity = new Point(0, -18);
           
          }

          if(_inputService.IsUpPressed())
          {
            Svelocity = new Point(0, 18);
          }

          if(_inputService.IsRightPressed())
          {
            Svelocity = new Point(-18, 0);
          }

          if(_inputService.IsLeftPressed())
          {
            Svelocity = new Point(18, 0);
          }

          }
          slime.SetVelocity(Svelocity);
        }

        for(int i =0;i <= Constants.DRAKEE_MAX_NUMBER; i++ )
        {
          Actor drakee = cast["Drakee"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED); 
          if(wallCheck >= 1)
          {
            

            if(_inputService.IsDownPressed())
          {
            Svelocity = new Point(0, -18);
           
          }

          if(_inputService.IsUpPressed())
          {
            Svelocity = new Point(0, 18);
          }

          if(_inputService.IsRightPressed())
          {
            Svelocity = new Point(-18, 0);
          }

          if(_inputService.IsLeftPressed())
          {
            Svelocity = new Point(18, 0);
          }

          }
          drakee.SetVelocity(Svelocity);
        }

        for(int i = 0; i < 1;i++){
          Actor dragon = cast["Dragon"][i];
          Point Svelocity = direction.Scale(Constants.MAP_SPEED); 
          if(wallCheck >= 1)
          {
            

            if(_inputService.IsDownPressed())
          {
            Svelocity = new Point(0, -18);
           
          }

          if(_inputService.IsUpPressed())
          {
            Svelocity = new Point(0, 18);
          }

          if(_inputService.IsRightPressed())
          {
            Svelocity = new Point(-18, 0);
          }

          if(_inputService.IsLeftPressed())
          {
            Svelocity = new Point(18, 0);
          }

          }
          dragon.SetVelocity(Svelocity);
        }

        Console.WriteLine($"{wallCheck}");
        wallCheck = 0;
        
      

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

    public int GetWallCheck()
    {
      return wallCheck;
    }


   
  }
  
}