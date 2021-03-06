using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;
using cse210_FinalProject_DragonQuest.Services;
using cse210_FinalProject_DragonQuest.Scripting;

namespace cse210_FinalProject_DragonQuest
{
    /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    public class Director
    {
        public bool _keepPlaying = true;
        private Dictionary<string, List<Actor>> _cast;
        private Dictionary<string, List<Action>> _script;

        public Director(Dictionary<string, List<Actor>> cast, Dictionary<string, List<Action>> script)
        {
            _cast = cast;
            _script = script;
        }

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void Direct()
        {
            Actor hero = _cast["Hero"][0];
            Actor Boss = _cast["Dragon"][0];
            
            
            while (_keepPlaying)
            {
                CueAction("input");
                CueAction("update");
                CueAction("output");

                if (Raylib_cs.Raylib.WindowShouldClose() || hero.GetHP() <= 0 || Boss.GetHP() <= 0)
                {
                    
                    _keepPlaying = false;
                    
                }
            }

            Console.WriteLine("Game over!");
        }

        /// <summary>
        /// Executes all of the actions for the provided phase.
        /// </summary>
        /// <param name="phase"></param>
        private void CueAction(string phase)
        {
            List<Action> actions = _script[phase];

            foreach (Action action in actions)
            {
                action.Execute(_cast);
            }
        }

    }
}