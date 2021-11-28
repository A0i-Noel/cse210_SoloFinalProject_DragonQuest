using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;
using cse210_FinalProject_DragonQuest.Services;


namespace cse210_FinalProject_DragonQuest.Scripting
{
    /// <summary>
    /// This function control ATTACK and SPELL.
    /// </summary>
    public class ActionActorsAction : Action
    {
      InputService _inputService;

      public ActionActorsAction(InputService inputService)
      {
        _inputService = inputService;
      }

      public override void Execute(Dictionary<string, List<Actor>>  cast)
      {
        Point direction = _inputService.GetDirection();

        Actor hero = cast["Hero"][0];

        Point velocity = direction.Scale(Constants.HERO_SPEED);
        hero.SetVelocity(velocity);
      }
    }
}