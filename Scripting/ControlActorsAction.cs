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
    public static int wallCheck;
    

    public ControlActorsAction(InputService inputService, PhysicsService physicsService)
    {
      _inputService = inputService;
      _physicsService = physicsService;
    }


    public override void Execute(Dictionary<string, List<Actor>> cast)
    {
      Point direction = _inputService.GetDirection();
      Point Rdirection = _inputService.GetReverseDirection();
      Point stop = new Point(0, 0);
      
      
      bool APress = _inputService.IsAPressed();
      bool SPress = _inputService.IsSPressed();
      bool DPress = _inputService.IsDPressed();

      Actor hero = cast["Hero"][0];

      List<Actor> Fields = cast["Field"];
      List<Actor> Walls = cast["Wall"];
      List<Actor> Waters = cast["Water"];
      List<Actor> Items = cast["Item"];
      List<Actor> Board = cast["Board"];
      List<Actor> message = cast["message"];
      List<Actor> Intro = cast["Intro"];


      wallCheck = 0;

      foreach(Actor wall in Walls)
      {
        if(_physicsService.IsCollision(hero, wall))
        {
          wallCheck += 1;
        }
      }


            for(int i =0;i < Fields.Count; i++ )
          {
            Actor field = cast["Field"][i];
            Point Svelocity = direction.Scale(Constants.MAP_SPEED);
            field.SetVelocity(Svelocity);
            if(wallCheck > 0)
            {
              Point Rvelocity = direction.Scale(Constants.MAP_SPEED * -1);
              field.SetVelocity(Rvelocity);
            }
            

          }


          for(int i =0;i < Waters.Count; i++ )
          {
            Actor Water = cast["Water"][i];
            Point Svelocity = direction.Scale(Constants.MAP_SPEED);
            Water.SetVelocity(Svelocity);
            if(wallCheck > 0)
            {
              Point Rvelocity = direction.Scale(Constants.MAP_SPEED * -1);
              Water.SetVelocity(Rvelocity);
            }
          }

          for(int i =0;i < Walls.Count; i++ )
          {
            Actor Wall = cast["Wall"][i];
            Point Svelocity = direction.Scale(Constants.MAP_SPEED);
            Wall.SetVelocity(Svelocity);
            if(wallCheck > 0)
            {
              Point Rvelocity = direction.Scale(Constants.MAP_SPEED * -1);
              Wall.SetVelocity(Rvelocity);
            }
          }

            for(int i =0;i < Items.Count; i++ )
          {
            Actor Herb = cast["Item"][i];
            Point Svelocity = direction.Scale(Constants.MAP_SPEED);
            Herb.SetVelocity(Svelocity);
            if(wallCheck > 0)
            {
              Point Rvelocity = direction.Scale(Constants.MAP_SPEED * -1);
              Herb.SetVelocity(Rvelocity);
            }
          }

          for(int i =0;i < Board.Count; i++ )
          {
            Actor board = cast["Board"][i];
            Point Svelocity = direction.Scale(Constants.MAP_SPEED);
            board.SetVelocity(Svelocity);
            if(wallCheck > 0)
            {
              Point Rvelocity = direction.Scale(Constants.MAP_SPEED * -1);
              board.SetVelocity(Rvelocity);
            }
          }

          for(int i =0;i < Intro.Count; i++ )
          {
            Actor intro = cast["Intro"][i];
            Point Svelocity = direction.Scale(Constants.MAP_SPEED);
            intro.SetVelocity(Svelocity);
            if(wallCheck > 0)
            {
              Point Rvelocity = direction.Scale(Constants.MAP_SPEED * -1);
              intro.SetVelocity(Rvelocity);
            }
          }

          for(int i =0;i < message.Count; i++ )
          {
            Actor Message = cast["message"][i];
            Point Svelocity = direction.Scale(Constants.MAP_SPEED);
            Message.SetVelocity(Svelocity);
            if(wallCheck > 0)
            {
              Point Rvelocity = direction.Scale(Constants.MAP_SPEED * -1);
              Message.SetVelocity(Rvelocity);
            }
          }
  
          List<Actor> slimes = cast["Slime"];
  
          for(int i =0;i < (int)slimes.Count; i++ )
          {
            Actor slime = cast["Slime"][i];
            Point Svelocity = direction.Scale(Constants.MAP_SPEED);
            slime.SetVelocity(Svelocity);
            if(wallCheck > 0)
            {
              Point Rvelocity = direction.Scale(Constants.MAP_SPEED * -1);
              slime.SetVelocity(Rvelocity);
            }
          }
  
          List<Actor> drakees = cast["Drakee"];
  
          for(int i =0;i < (int)drakees.Count; i++ )
          {
            Actor drakee = cast["Drakee"][i];
            Point Svelocity = direction.Scale(Constants.MAP_SPEED);
            drakee.SetVelocity(Svelocity);
            if(wallCheck > 0)
            {
              Point Rvelocity = direction.Scale(Constants.MAP_SPEED * -1);
              drakee.SetVelocity(Rvelocity);
            }
          }
  
          List<Actor> dragons = cast["Dragon"];
  
          for(int i = 0; i < (int)dragons.Count;i++){
            Actor dragon = cast["Dragon"][i];
            Point Svelocity = direction.Scale(Constants.MAP_SPEED);
            dragon.SetVelocity(Svelocity);
            if(wallCheck > 0)
            {
              Point Rvelocity = direction.Scale(Constants.MAP_SPEED * -1);
              dragon.SetVelocity(Rvelocity);
            }
          }
        

        

        Console.WriteLine($"{wallCheck}");
        
        
      

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

    // public int GetWallCheck()
    // {
    //   return wallCheck;
    // }

    public static int WC()
    {
      return wallCheck;
    }
  }
  
}