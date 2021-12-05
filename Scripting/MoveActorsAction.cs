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
         public MoveActorsAction()
        {
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

            int newX = (x + dx);
            int newY = (y + dy);

            // if (newX < 0)
            // {
            //     newX = Constants.MAX_X;
            // }

            // if (newY < 0)
            // {
            //     newY = Constants.MAX_Y;
            // }

            actor.SetPosition(new Point(newX, newY));
        }

    }
}