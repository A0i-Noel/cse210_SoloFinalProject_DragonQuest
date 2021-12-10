using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;
using cse210_FinalProject_DragonQuest.Services;


namespace cse210_FinalProject_DragonQuest.Scripting
{
    /// <summary>
    /// This function calculate and display HP and MP. Also,
    /// </summary>
    public class StatusActorsAction : Action
    {
       public StatusActorsAction()
        {
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
          Actor hero = cast["Hero"][0];
        }

        

       

        
    }
}