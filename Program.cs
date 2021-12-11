using System;
using cse210_FinalProject_DragonQuest.Services;
using cse210_FinalProject_DragonQuest.Casting;
using cse210_FinalProject_DragonQuest.Scripting;
using System.Collections.Generic;

namespace cse210_FinalProject_DragonQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            cast["Field"] = new List<Actor>();
            cast["Water"] = new List<Actor>();
            cast["Wall"] = new List<Actor>();
            
            for (int c = 0;c < 54;c++){
                for(int r = 0;r <80;r++){
                    Field _Field = new Field(76 + (76 * r), 76 + (76 * c));
                    cast["Field"].Add(_Field);
                }
            }

            for(int i =0; i <200; i++)
            {
                Random r1 = new System.Random();
                Random r2 = new System.Random();
                int x = r1.Next(0, 2432);
                int y = r2.Next(760, 3164);
                Tree _Tree = new Tree(x, y);
                cast["Wall"].Add(_Tree);
            }

            for (int c = 0;c < 15;c++){
                for(int r = 0;r <10 + c;r++){
                    sMountain _sMountain = new sMountain(1216 + (76 * r) - (76 * c), 3496 + (76 * c));
                    cast["Field"].Add(_sMountain);
                }
            }

            for (int c = 0;c < 16;c++){
                for(int r = 0;r <41;r++){
                    Desert _Desert = new Desert(2964 + (76 * r), 2888 + (76 * c));
                    cast["Field"].Add(_Desert);
                }
            }

            for (int c = 0;c < 16;c++){
                for(int r = 0;r <5 + c;r++){
                    Desert _Desert = new Desert(2660 + (76 * r) - (76 * c), 2888 + (76 * c));
                    cast["Field"].Add(_Desert);
                }
            }

            for (int c = 0;c < 25;c++){
                for(int r = 0;r < 8 + c;r++){
                    Desert _Desert = new Desert(5472 + (76 * r) - (76 * c), 1061 + (76 * c));
                    cast["Field"].Add(_Desert);
                }
            }


            for (int c = 0;c < 6;c++){
                for(int r = 0;r <100;r++){
                    hMountain _hMountain = new hMountain(-532 + (76 * r), -380 + (76 * c));
                    cast["Wall"].Add(_hMountain);
                }
            }

            for (int c = 0;c < 69;c++){
                for(int r = 0;r <8;r++){
                    hMountain _hMountain = new hMountain(-532 + (76 * r), -380 + (76 * c));
                    cast["Wall"].Add(_hMountain);
                }
            }

            for (int c = 0;c < 69;c++){
                for(int r = 0;r <8;r++){
                    hMountain _hMountain = new hMountain(6000 + (76 * r), -380 + (76 * c));
                    cast["Wall"].Add(_hMountain);
                }
            }

            for (int c = 0;c < 6;c++){
                for(int r = 0;r < 100;r++){
                    hMountain _hMountain = new hMountain(-532 + (76 * r), 4100 + (76 * c));
                    cast["Wall"].Add(_hMountain);
                }
            }

            for (int c = 0;c < 24;c++){
                for(int r = 0;r < 8;r++){
                    hMountain _hMountain = new hMountain(2964 + (76 * r) - (76 * c), 1976 + (76 * c));
                    cast["Wall"].Add(_hMountain);
                }
            }

            for (int c = 0;c < 24;c++){
                for(int r = 0;r < 8;r++){
                    hMountain _hMountain = new hMountain(4712 + (76 * r) - (76 * c), 1061 + (76 * c));
                    cast["Wall"].Add(_hMountain);
                }
            }

            for (int c = 0;c < 7;c++){
                for(int r = 0;r < 1 + c;r++){
                    hMountain _hMountain = new hMountain(5392 + (76 * r) - (76 * c), 3544 + (76 * c));
                    cast["Wall"].Add(_hMountain);
                }
            }

            for (int c = 0;c < 4;c++){
                for(int r = 0;r < 7 - c;r++){
                    hMountain _hMountain = new hMountain(5544 + (76 * r) + (152 * c), 3544 + (76 * c));
                    cast["Wall"].Add(_hMountain);
                }
            }

            for (int c = 0;c < 7;c++){
                for(int r = 0;r < 7;r++){
                    hMountain _hMountain = new hMountain(5544 + (76 * r), 3088 + (76 * c));
                    cast["Wall"].Add(_hMountain);
                }
            }

            for (int c = 0;c < 13;c++){
                for(int r = 0;r < 2 + (c - 2);r++){
                    hMountain _hMountain = new hMountain(5924 + (76 * r) - (76 * (c - 2)), 2176 + (76 * c));
                    cast["Wall"].Add(_hMountain);
                }
            }

            for (int c = 0;c < 3;c++){
                for(int r = 0;r < 7 - (c * 2) ;r++){
                    hMountain _hMountain = new hMountain(5088 + (76 * r) + (76 * (c * 2)), 3088 + (76 * c));
                    cast["Wall"].Add(_hMountain);
                }
            }


            for (int c = 0;c < 10;c++){
                for(int r = 0;r < 8 - c ;r++){
                    Sea _Sea = new Sea(0 + (76 * r), 4028 - (76 * c));
                    cast["Wall"].Add(_Sea);
                }
            }

            for (int c = 0;c < 5;c++){
                for(int r = 0;r < 3 + (c * 2);r++){
                    Sea _Sea = new Sea(608 + (76 * r) - (76 * c), 2128 + (76 * c));
                    cast["Wall"].Add(_Sea);
                }
            }

            for (int c = 0;c < 5;c++){
                for(int r = 0;r < 11 - (c * 2);r++){
                    Sea _Sea = new Sea(912 + (76 * r) + (76 * c), 2508 + (76 * c));
                    cast["Wall"].Add(_Sea);
                }
            }

            for (int c = 0;c < 3;c++){
                for(int r = 0;r < 20;r++){
                    Tree _Tree = new Tree(0 + (76 * r), 0 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 4;c++){
                for(int r = 0;r < 6 - c;r++){
                    Tree _Tree = new Tree(0 + (76 * r), 228 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 4;c++){
                for(int r = 0;r < 3 + c;r++){
                    Tree _Tree = new Tree(0 + (76 * r), 532 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 10;c++){
                for(int r = 0;r < 7 + c;r++){
                    Tree _Tree = new Tree(684 + (76 * r) + (76 * c), 228 + (76 * c) );
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 10;c++){
                for(int r = 0;r < 41 - (c * 5);r++){
                    Tree _Tree = new Tree(2964 + (76 * r) + (76 * 5 * c), 0 + (76 * c) );
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 12;c++){
                for(int r = 0;r < 3 + (c % 2);r++){
                    Tree _Tree = new Tree(2736 + (76 * r), 1292 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 8;c++){
                for(int r = 0;r < 6;r++){
                    Tree _Tree = new Tree(1976 + (76 * r) + (76 * c), 152 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 8;c++){
                for(int r = 0;r < 6;r++){
                    Tree _Tree = new Tree(2584 + (76 * r) + (76 * c), 76 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 8;c++){
                for(int r = 0;r < 6 + c;r++){
                    Tree _Tree = new Tree(1976 + (76 * r) + (76 * c), 532 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }

          

            for (int c = 0;c < 1;c++){
                for(int r = 0;r < 15;r++){
                    Tree _Tree = new Tree(2964 + (76 * r), 1216 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 3;c++){
                for(int r = 0;r < 3 + (c * 2);r++){
                    Tree _Tree = new Tree(3724 + (76 * r), 1216 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 5;c++){
                for(int r = 0;r < 3 + (c * 2);r++){
                    Tree _Tree = new Tree(3876 + (76 * r) - (76 * c), 532 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 5;c++){
                for(int r = 0;r < 11 - (c * 2);r++){
                    Tree _Tree = new Tree(3572 + (76 * r) + (76 * c), 912 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 2;c++){
                for(int r = 0;r < 11;r++){
                    Tree _Tree = new Tree(4560 + (76 * r), 608 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }
            for (int c = 0;c < 4;c++){
                for(int r = 0;r < 2;r++){
                    Tree _Tree = new Tree(4560 + (76 * r) + (76 * c * 2), 760 + (76 * c));
                    cast["Wall"].Add(_Tree);
                }
            }

            for (int c = 0;c < 2;c++){
                for(int r = 0;r < 2 + (c * 2);r++){
                    Water _Water = new Water(3268 + (76 * r) - (76 * c), 1368 + (76 * c));
                    cast["Water"].Add(_Water);
                }
            }

            for (int c = 0;c < 2;c++){
                for(int r = 0;r < 4 - (c * 2);r++){
                    Water _Water = new Water(3192 + (76 * r) + (76 * c), 1520 + (76 * c));
                    cast["Water"].Add(_Water);
                }
            }

        
        


            cast["Attack"] = new List<Actor>();
            Attack _Attack = new Attack();
            cast["Attack"].Add(_Attack);

            cast["Slime"] = new List<Actor>();
            Slime _Slime = new Slime(Constants.MAX_X/2, 300);
            cast["Slime"].Add(_Slime);
            for (int i = 1; i <= Constants.SLIME_MAX_NUMBER; i++)
            {
                Random r1 = new System.Random();
                Random r2 = new System.Random();
                int x = r1.Next(0, Constants.MAX_X);
                int y = r2.Next(0, Constants.MAX_Y);
                Slime slime = new Slime(x, y);
                cast["Slime"].Add(slime);
            }


           

 
            cast["Drakee"] = new List<Actor>();
            Drakee _Drakee = new Drakee(Constants.MAX_X/2, 600);
            cast["Drakee"].Add(_Drakee);
            for (int i = 1; i <= Constants.DRAKEE_MAX_NUMBER; i++)
            {
                Random r1 = new System.Random();
                Random r2 = new System.Random();
                int x = r1.Next(0, Constants.MAX_X);
                int y = r2.Next(0, Constants.MAX_Y);
                Drakee drakee = new Drakee(x, y);
                cast["Drakee"].Add(drakee);
            }

     

            cast["Dragon"] = new List<Actor>();
            Dragon _Dragon = new Dragon(5800 , 3900);
            Dragon _Dragon2 = new Dragon(8000, 8000);
            cast["Dragon"].Add(_Dragon);
            cast["Dragon"].Add(_Dragon2);


            cast["Hero"] = new List<Actor>();
            Hero _Hero = new Hero();
            cast["Hero"].Add(_Hero);

            

            cast["Status"] = new List<Actor>();
            Status _Status = new Status();
            cast["Status"].Add(_Status);


            

           
            

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            

            script["output"] = new List<Action>();

            script["input"] = new List<Action>();
            ControlActorsAction _CAA = new ControlActorsAction(inputService, physicsService);
            script["input"].Add(_CAA);

            script["update"] = new List<Action>();
            MoveActorsAction _MAA = new MoveActorsAction(inputService, physicsService);
            script["update"].Add(_MAA);
            HandleCollisionAction _HCA = new HandleCollisionAction(physicsService, inputService, audioService);
            script["update"].Add(_HCA);

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.

            // Start up the game
            outputService.OpenWindow(Constants.Screen_X, Constants.Screen_Y, "Dragon-Quest", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}

