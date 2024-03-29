﻿using System;
using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.Wrappers
{
  public class TriggerWrapper
  {
    public TriggerWrapper()
    {
      Trigger = CreateTrigger();
    }

    public trigger Trigger { get; }

    public void RegisterUnitEvent(unit whichUnit, unitevent whichEvent)
    {
      TriggerRegisterUnitEvent(Trigger, whichUnit, whichEvent);
    }

    public void RegisterFrameEvent(framehandle frame, frameeventtype frameeventtype)
    {
      BlzTriggerRegisterFrameEvent(Trigger, frame, frameeventtype);
    }

    public void AddAction(Action actionFunc)
    {
      TriggerAddAction(Trigger, actionFunc);
    }

    ~TriggerWrapper()
    {
      DestroyTrigger(Trigger);
    }
  }
}