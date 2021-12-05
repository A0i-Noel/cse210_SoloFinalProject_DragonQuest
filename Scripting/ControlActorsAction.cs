using System.Collections.Generic;
using cse210_FinalProject_DragonQuest.Casting;
using cse210_FinalProject_DragonQuest.Services;
using System;

namespace cse210_FinalProject_DragonQuest.Scripting
{
  public class ControlActorsAction : Action
  {
    InputService _inputService;

    public ControlActorsAction(InputService inputService)
    {
      _inputService = inputService;
    }

    public override void Execute(Dictionary<string, List<Actor>> cast)
    {
      Point direction = _inputService.GetDirection();
      bool APress = _inputService.IsAPressed();
      bool SPress = _inputService.IsSPressed();
      bool DPress = _inputService.IsDPressed();


      for(int i =0;i <= Constants.SLIME_MAX_NUMBER; i++ )
      {
        Actor slime = cast["Slime"][i];
        Point Svelocity = direction.Scale(Constants.SLIME_SPEED);
        slime.SetVelocity(Svelocity);
      }

      for(int i =0;i <= Constants.DRAKEE_MAX_NUMBER; i++ )
      {
        Actor drakee = cast["Drakee"][i];
        Point Dvelocity = direction.Scale(Constants.DRAKEE_SPEED);
        drakee.SetVelocity(Dvelocity);
      }
      
      Actor dragon = cast["Dragon"][0];
      Point Dravelocity = direction.Scale(Constants.DRAGON_SPEED);
      dragon.SetVelocity(Dravelocity);
    }

  }
  
}