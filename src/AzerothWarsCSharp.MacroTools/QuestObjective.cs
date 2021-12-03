﻿using System;

namespace AzerothWarsCSharp.MacroTools
{
  public abstract class QuestObjective
  {
    public event EventHandler<QuestObjectiveEventArgs>? ProgressChanged;
    
    public string Description { get; protected init; } = "DefaultObjectiveText";
    
    internal Quest? ParentQuest { get; set; }
    
    protected Faction? ParentFaction => ParentQuest?.ParentFaction;

    private QuestProgress _progress;
    
    public QuestProgress Progress
    {
      protected set
      {
        _progress = value;
        ProgressChanged?.Invoke(this, new QuestObjectiveEventArgs(this));
        Console.WriteLine("Quest objective changed progress");
      }
      get => _progress;
    }
  }
}