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
            
            ControlActorsAction CAA = new ControlActorsAction(_inputService, _physicsService);
            
            int x = actor.GetX();
            int y = actor.GetY();

            int dx = actor.GetVelocity().GetX();
            int dy = actor.GetVelocity().GetY();

            int newX = (x + dx);
            int newY = (y + dy);

            int Checker = CAA.GetWallCheck();

            if(Checker >= 1)
            {
                newX = x;
                newY = y;
            }

           

           

            actor.SetPosition(new Point(newX, newY));
            // wall = true;
        }

     

    }
}