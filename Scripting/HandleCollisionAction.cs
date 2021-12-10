using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;
using cse210_FinalProject_DragonQuest.Services;
using System;

namespace cse210_FinalProject_DragonQuest.Scripting
{
    /// <summary>
    /// An action to draw all of the actors in the game.
    /// </summary>
    public class HandleCollisionAction : Action
    {
        private PhysicsService _physicsService;
        private InputService _inputServise;
        private AudioService _audioServise;
        Random rnd = new Random();

        public HandleCollisionAction(PhysicsService physicsService, InputService inputService, AudioService audioService)
        {
            _physicsService = physicsService;
            _inputServise = inputService;
            _audioServise = audioService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            
            
            Actor a = (Attack)cast["Attack"][0];
            Actor hero = cast["Hero"][0];
            List<Actor> slimes = cast["Slime"];
            List<Actor> drakees = cast["Drakee"];
            Actor dragon = cast["Dragon"][0];
            Actor status = cast["Status"][0];
            Status _status = (Status)status;

            List<Actor> Sremove = new List<Actor>();
            List<Actor> Dremove = new List<Actor>();

            // for monster and hero actions

            foreach(Actor slime in slimes)
            {
                
                if(_physicsService.IsCollision(a, slime) && _inputServise.IsAPressed())
                {
                    Attack(hero, slime);
                    if(Die(slime))
                    {
                        Sremove.Add(slime);
                    }

                    Random r = new Random();
                    int Mfaze = r.Next(1, 4);
                    if(Mfaze == 1)
                    {
                        Attack(slime, hero);
                        _status.UpdateText();

                        Console.WriteLine($"{hero.GetHP()}");
                    }
                }
            }
            foreach(Actor slime in Sremove)
            {
                cast["Slime"].Remove(slime);
            }

            

            foreach(Actor actor in drakees)
            {
                Drakee drakee = (Drakee)actor;
                if(_physicsService.IsCollision(a, drakee) && _inputServise.IsAPressed())
                {
                    Attack(hero, drakee);
                    if(Die(drakee))
                    {
                 
                    }

                    Random r = new Random();
                    int Mfaze = r.Next(1, 6);
                    if(Mfaze == 1)
                    {
                        Attack(drakee, hero);
                        _status.UpdateText();
                    }
                }
            }
                if(_physicsService.IsCollision(a, dragon) && _inputServise.IsAPressed())
                {
                    Attack(hero, dragon);
                    if(Die(dragon))
                    {
                       
                    }

                    Random r = new Random();
                    int Mfaze = r.Next(1, 7);
                    if(Mfaze == 1)
                    {
                        Attack(dragon, hero);
                        _status.UpdateText();
                    }
                }
        }

        public void Attack(Actor first, Actor second)
        {
            int hp = second.GetHP();
            hp -= first.GetMighty() - rnd.Next(-1, 1);
            second.SetHP(hp);
            _audioServise.PlaySound(Constants.SOUND_ATTACK);
            Console.WriteLine($"{hp}");
        }

        public bool Die(Actor actor)
        {
            int life = actor.GetHP();
            
            return life <= 0;
        }

        
        

    }
}