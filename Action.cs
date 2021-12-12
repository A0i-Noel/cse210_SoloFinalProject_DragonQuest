using System;
using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;

namespace cse210_FinalProject_DragonQuest
{
    
    /// <summary>
    /// The base class of all other actions.
    /// </summary>
    public abstract class Action
    {
        
        public abstract void Execute(Dictionary<string, List<Actor>> cast);
    }
}