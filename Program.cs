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
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();


          
            cast["Hero"] = new List<Actor>();
            Hero _Hero = new Hero();
            cast["Hero"].Add(_Hero);

            cast["Status"] = new List<Actor>();
            Status _Status = new Status();
            cast["Status"].Add(_Status);


            

           
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
            cast["Dragon"].Add(_Dragon);

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();

            script["input"] = new List<Action>();
            ControlActorsAction _CAA = new ControlActorsAction(inputService);
            script["input"].Add(_CAA);

            script["update"] = new List<Action>();
            MoveActorsAction _MAA = new MoveActorsAction();
            script["update"].Add(_MAA);

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

