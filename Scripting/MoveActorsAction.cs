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
        PhysicsService _physicsService;
        bool wall = true;
         public MoveActorsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            
            Actor hero = cast["Hero"][0];
            List<Actor> Trees = cast["Tree"];
            List<Actor> Seas = cast["Sea"];
            List<Actor> hMountains = cast["hMountain"];
            

            foreach(Actor mountain in hMountains)
            {
                CollisionWall(hero, mountain);
            }
            foreach(Actor tree in Trees)
            {
                CollisionWall(hero, tree);
            }
            foreach(Actor sea in Seas)
            {
                CollisionWall(hero, sea);
            }

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

           

           

            actor.SetPosition(new Point(newX, newY));
            // wall = true;
        }

        public bool CollisionWall(Actor actor, Actor map)
    {
      
      
        Console.WriteLine("Wall!!");
        return _physicsService.IsCollision(actor, map);
      
      
    }

    }
}