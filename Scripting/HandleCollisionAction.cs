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
            List<Actor>  Herbs = cast["Item"];

            List<Actor> Sremove = new List<Actor>();
            List<Actor> Dremove = new List<Actor>();
            List<Actor> Draremove = new List<Actor>();
            List<Actor> Hremove = new List<Actor>();

            // for monster and hero actions

            // Slime actions

            foreach(Actor slime in slimes)
            {
                
                if(_physicsService.IsCollision(a, slime)) 
                {
                    if(_inputServise.IsAPressed())
                    {
                        Attack(hero, slime);

                        Random r = new Random();
                        int Mfaze = r.Next(1, 4);
                        if(Mfaze == 1)
                        {
                            Attack(slime, hero);
                            _status.UpdateText();

                            Console.WriteLine($"{hero.GetHP()}");
                        }

                    }

                    if(_inputServise.IsDPressed())
                    {
                        if(hero.GetMP() >= 4)
                        {
                            Frizz(hero, slime);
                            hero.SetMP(hero.GetMP() - 4);
                        }else{
                            // MP is not enough
                        }
                        
                    }

                    if(Die(slime))
                        {
                            int EXP = slime.GetEXP();
                            int HEXP = hero.GetEXP();
                            HEXP += EXP;
                            hero.SetEXP(HEXP);
                            LevelUpCheck(hero);
                            Sremove.Add(slime);

                        }
                    
                }

                if(_physicsService.IsCollision(hero, slime))
                {
                    Random r = new Random();
                    int Mfaze = r.Next(1,25);
                    if(Mfaze <= 1)
                    {
                        Attack(slime, hero);
                    } 
                    _status.UpdateText();
                }
            }
            if(Sremove.Count >= 1)
            {
                Actor die = Sremove[0];
                cast["Slime"].Remove(die);
            }
                
            
            // Drakee Actions
            

            foreach(Actor actor in drakees)
            {
                Drakee drakee = (Drakee)actor;
                if(_physicsService.IsCollision(a, drakee))
                {
                    if(_inputServise.IsAPressed())
                    {
                        Attack(hero, drakee);
                        

                        Random r = new Random();
                        int Mfaze = r.Next(1, 6);
                        if(Mfaze <= 2)
                        {
                            Attack(drakee, hero);
                            _status.UpdateText();
                        } else if(Mfaze == 6){
                            Frizz(drakee, hero);
                            _status.UpdateText();
                        }
                    }

                    if(_inputServise.IsDPressed())
                    {
                        if(hero.GetMP() >= 4)
                        {
                            Frizz(hero, drakee);
                            hero.SetMP(hero.GetMP() - 4);
                        }else{
                            // MP is not enough
                        }
                        
                    }

                    if(Die(drakee))
                        {
                            int EXP = drakee.GetEXP();
                            int HEXP = hero.GetEXP();
                            HEXP += EXP;
                            hero.SetEXP(HEXP);
                            LevelUpCheck(hero);
                            Dremove.Add(drakee);
                        }


                }
                

                if(_physicsService.IsCollision(hero, drakee))
                {
                    Random r = new Random();
                    int Mfaze = r.Next(1,30);
                    if(Mfaze <= 2)
                    {
                        Attack(drakee, hero);
                    } else if(Mfaze == 30){
                        Frizz(drakee, hero);
                    }
                    _status.UpdateText();
                }
            }
            if(Dremove.Count >= 1)
            {
                Actor die = Dremove[0];
                cast["Drakee"].Remove(die);
            }


            // Dragon actions

                if(_physicsService.IsCollision(a, dragon))
                {
                    if(_inputServise.IsAPressed())
                    {
                         Attack(hero, dragon);
                        

                        Random r = new Random();
                        int Mfaze = r.Next(1, 7);
                        if(Mfaze == 1)
                        {
                            Attack(dragon, hero);
                            _status.UpdateText();
                        }
                    }

                    if(_inputServise.IsDPressed())
                    {
                        if(hero.GetMP() >= 4)
                        {
                            Frizz(hero, dragon);
                            hero.SetMP(hero.GetMP() - 4);
                        }else{
                            // MP is not enough
                        }
                        
                    }

                    if(Die(dragon))
                        {
                            int EXP = dragon.GetEXP();
                            int HEXP = hero.GetEXP();
                            HEXP += EXP;
                            hero.SetEXP(HEXP);
                            LevelUpCheck(hero);
                           Draremove.Add(dragon);
                        }
                    
                }
                if(_physicsService.IsCollision(hero, dragon))
                {
                    Random r = new Random();
                    int Mfaze = r.Next(1,30);
                    if(Mfaze <= 2)
                    {
                        Attack(dragon, hero);
                    } else if(Mfaze >= 29){
                        Frizz(dragon, hero);
                    }
                    _status.UpdateText();
                }
                if(Draremove.Count >= 1)
            {
                Actor die = Draremove[0];
                cast["Dragon"].Remove(die);
            }

            // Heal Action

            if(_inputServise.IsSPressed() && hero.GetMP() >= 3)
            {
                Heal(hero);
                hero.SetMP(hero.GetMP() - 3);
            }

            // Herb Action
            foreach(Actor herb in Herbs)
            {
                if(_physicsService.IsCollision(hero, herb))
                {
                    hero.SetHP(hero.GetHP() + 5);
                    Hremove.Add(herb);
                }
            }

            if(Hremove.Count >= 1)
            {
                Actor die = Hremove[0];
                cast["Item"].Remove(die);
            }
        }

        public void Attack(Actor first, Actor second)
        {
            int hp = second.GetHP();
            hp -= first.GetMighty() - rnd.Next(-1, 1);
            second.SetHP(hp);
            _audioServise.PlaySound(Constants.SOUND_ATTACK);
            // Console.WriteLine($"{hp}");
        }

        public void Frizz(Actor first, Actor second)
        {
            int hp = second.GetHP();
            hp -= first.GetMighty() + rnd.Next(4, 6);
            second.SetHP(hp);
            _audioServise.PlaySound(Constants.SOUND_SPELL);
            // Console.WriteLine($"{hp}");
        }

        public void Heal(Actor hero)
        {
            Random r = new Random();
            int Heal = r.Next(5, 8);
            hero.SetHP(hero.GetHP() + Heal);
            _audioServise.PlaySound(Constants.SOUND_SPELL);
        }

        public bool Die(Actor actor)
        {
            int life = actor.GetHP();
            
            return life <= 0;
        }

        public void LevelUpCheck(Actor hero)
        {
            List<int> NeedEXP = hero.GetNeedEXP();
            int HEXP = hero.GetEXP();
            if(HEXP >= NeedEXP[0])
            {
                int HeroLv = hero.GetLevel();
                _audioServise.PlaySound(Constants.SOUND_LEVELUP);
                HeroLv += 1;
                hero.SetLevel(HeroLv);
                StatusUp(hero);
                NeedEXP.RemoveAt(0);
            }

        }

        public void StatusUp(Actor hero)
        {
            hero.SetMAX_HP(hero.GetMAX_HP() + 5);
            hero.SetMAX_MP(hero.GetMAX_MP() + 5);
            hero.SetHP(hero.GetMAX_HP());
            hero.SetMP(hero.GetMAX_MP());
            hero.SetMighty(hero.GetMighty() + 2);
            
        }

        
        

    }
}