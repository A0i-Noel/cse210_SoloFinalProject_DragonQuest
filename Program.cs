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
            Hero _Hero = new Hero(Constants.MAX_X / 2, Constants.MAX_Y / 2);
            cast["Hero"].Add(_Hero);

            

           
            cast["Slime"] = new List<Actor>();
            Slime _Slime = new Slime(Constants.MAX_X/2, 300);
            cast["Slime"].Add(_Slime);


           

 
            cast["Drakee"] = new List<Actor>();
            Drakee _Drakee = new Drakee(Constants.MAX_X/2, 600);
            cast["Drakee"].Add(_Drakee);

     

            cast["Dragon"] = new List<Actor>();
            Dragon _Dragon = new Dragon(Constants.MAX_X/2 , 100);
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
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Dragon-Quest", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}

