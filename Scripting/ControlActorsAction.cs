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
            field.SetOLD_X(field.GetX());
            field.SetOLD_Y(field.GetY());
            Point Svelocity = stop.Scale(Constants.MAP_SPEED);
            if(wallCheck == 0)
            {
              Svelocity = direction.Scale(Constants.MAP_SPEED);
            // }else{
            //   Svelocity = Rdirection.Scale(Constants.MAP_SPEED);
            }
             
            field.SetVelocity(Svelocity);


          }


          for(int i =0;i < Waters.Count; i++ )
          {
            Actor Water = cast["Water"][i];
            Water.SetOLD_X(Water.GetX());
            Water.SetOLD_Y(Water.GetY());
            Point Svelocity = stop.Scale(Constants.MAP_SPEED);
            if(wallCheck == 0)
            {
              Svelocity = direction.Scale(Constants.MAP_SPEED);
            }
            // else{
            //   Svelocity = Rdirection.Scale(Constants.MAP_SPEED);
            // }
             
            Water.SetVelocity(Svelocity);
          }

          for(int i =0;i < Walls.Count; i++ )
          {
            Actor Wall = cast["Wall"][i];
            Wall.SetOLD_X(Wall.GetX());
            Wall.SetOLD_Y(Wall.GetY());
            Point Svelocity = stop.Scale(Constants.MAP_SPEED);
            if(wallCheck == 0)
            {
              Svelocity = direction.Scale(Constants.MAP_SPEED);
            }
            // else{
            //   Svelocity = Rdirection.Scale(Constants.MAP_SPEED);
            // }
             
            Wall.SetVelocity(Svelocity);
          }

            for(int i =0;i < Items.Count; i++ )
          {
            Actor Herb = cast["Item"][i];
            Herb.SetOLD_X(Herb.GetX());
            Herb.SetOLD_Y(Herb.GetY());
            Point Svelocity = stop.Scale(Constants.MAP_SPEED);
            if(wallCheck == 0)
            {
              Svelocity = direction.Scale(Constants.MAP_SPEED);
            }
            // else{
            //   Svelocity = Rdirection.Scale(Constants.MAP_SPEED);
            // }
             
            Herb.SetVelocity(Svelocity);
          }
  
          List<Actor> slimes = cast["Slime"];
  
          for(int i =0;i < (int)slimes.Count; i++ )
          {
            Actor slime = cast["Slime"][i];
            slime.SetOLD_X(slime.GetX());
            slime.SetOLD_Y(slime.GetY());
            Point Svelocity = stop.Scale(Constants.MAP_SPEED);
            if(wallCheck == 0)
            {
              Svelocity = direction.Scale(Constants.MAP_SPEED);
            }
            // else{
            //   Svelocity = Rdirection.Scale(Constants.MAP_SPEED);
            // }
             
            slime.SetVelocity(Svelocity);
          }
  
          List<Actor> drakees = cast["Drakee"];
  
          for(int i =0;i < (int)drakees.Count; i++ )
          {
            Actor drakee = cast["Drakee"][i];
            drakee.SetOLD_X(drakee.GetX());
            drakee.SetOLD_Y(drakee.GetY());
            Point Svelocity = stop.Scale(Constants.MAP_SPEED);
            if(wallCheck == 0)
            {
              Svelocity = direction.Scale(Constants.MAP_SPEED);
            }
            // else{
            //   Svelocity = Rdirection.Scale(Constants.MAP_SPEED);
            // }
             
            drakee.SetVelocity(Svelocity);
          }
  
          List<Actor> dragons = cast["Dragon"];
  
          for(int i = 0; i < (int)dragons.Count;i++){
            Actor dragon = cast["Dragon"][i];
            dragon.SetOLD_X(dragon.GetX());
            dragon.SetOLD_Y(dragon.GetY());
            Point Svelocity = stop.Scale(Constants.MAP_SPEED);
            if(wallCheck == 0)
            {
              Svelocity = direction.Scale(Constants.MAP_SPEED);
            }
            // else{
            //   Svelocity = Rdirection.Scale(Constants.MAP_SPEED);
            // }
             
            dragon.SetVelocity(Svelocity);
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