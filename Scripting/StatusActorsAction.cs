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
        Status _status;
       public StatusActorsAction(Status s)
        {
            _status = s;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
          _status.UpdateText();
        }

        

       

        
    }
}