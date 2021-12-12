using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;
using cse210_FinalProject_DragonQuest.Services;
using System;


namespace cse210_FinalProject_DragonQuest.Scripting
{
    /// <summary>
    /// An action to draw all of the actors in the game.
    /// </summary>
    public class MoveActorsAction : Action
    {
        InputService _inputService;
        PhysicsService _physicsService;
        public static int wallCheck;
        
         public MoveActorsAction(InputService inputService, PhysicsService physicsService)
        {
            _inputService = inputService;
            _physicsService = physicsService;
        }

         

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
         

            foreach (List<Actor> group in cast.Values)
            {
                foreach (Actor actor in group)
                {
                   
                        MoveActor(actor);
                    
                }
            }
        }
        
        private void MoveActor(Actor actor)
        {
            
           
            
            int x = actor.GetX();
            int y = actor.GetY();

            int dx = actor.GetVelocity().GetX();
            int dy = actor.GetVelocity().GetY();

            if(ControlActorsAction.WC() >= 1)
            {
                dx = -dx;
                dy = -dy;
            }

            int newX = (x + dx);
            int newY = (y + dy);
            // ControlActorsAction CAA = new ControlActorsAction(_inputService, _physicsService);
            // int Checker = CAA.wallCheck;
            // Console.WriteLine($"{Checker}");
            

            


            actor.SetPosition(new Point(newX, newY));
            // CAA.SetWallCheck(0);
           
            
            
        }

     

    }
}