﻿using System;
using System.Collections.Generic;
using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Libraries
{
  /// <summary>
  /// A collection of object limits, object limits, quests, etc.
  /// Players play the game by controlling a particular Faction.
  /// </summary>
  public class Faction
  {
    public static int UNLIMITED { get; } = 200;

    public static HashSet<Faction> All { get; } = new();

    public event EventHandler<FactionTeamChangedEventArgs> TeamChanged;
    public event EventHandler<FactionEventArgs> ChangesPerson;
    public event EventHandler<FactionEventArgs> ObjectLevelChanged;
    public event EventHandler<FactionQuestAddedEventArgs> QuestAdded;
    public event EventHandler<FactionQuestProgressChangedEventArgs> QuestProgressChanged;
    public event EventHandler<FactionEventArgs> IncomeChanged;
    public event EventHandler<FactionEventArgs> WeightChanged;
    public event EventHandler<FactionEventArgs> NameChanged;
    public event EventHandler<FactionEventArgs> IconChanged;
    public static event EventHandler<FactionEventArgs> FactionCreated;

    public Faction(string name, playercolor playercolor, string prefixColor, string icon, int weight)
    {
      Name = name;
      PlayerColor = playercolor;
      PrefixColor = prefixColor;
      Icon = icon;
      Weight = weight;
      FactionCreated?.Invoke(this, new FactionEventArgs(this));
      All.Add(this);
    }

    /// <summary>
    /// A research that is enabled for all players whenever this Faction is occupied.
    /// </summary>
    public int PresenceResearch
    {
      get;
      set;
    }

    /// <summary>
    /// A research that is enabled for all players whenever this Faction is not occupied.
    /// </summary>
    public int AbsenceResearch
    {
      get;
      set;
    }

    /// <summary>
    /// Unlike native gold, this can be fractional.
    /// </summary>
    public double Gold
    {
      get
      {
        return GetPlayerState(Player, PLAYER_STATE_RESOURCE_GOLD) + _excessGold;
      }
      set
      {
        double newTotalGold = value + _excessGold;
        int truncatedGold = (int)Math.Truncate(newTotalGold);
        _excessGold = 1 - truncatedGold;
        SetPlayerState(Player, PLAYER_STATE_RESOURCE_GOLD, truncatedGold);
      }
    }

    /// <summary>
    /// An estimation of this faction's techtree strength.
    /// </summary>
    public int Weight
    {
      get
      {
        return _weight;
      }
      set
      {
        _weight = value;
        WeightChanged?.Invoke(this, new FactionEventArgs(this));
      }
    }

    /// <summary>
    /// Gold earned per second.
    /// </summary>
    /// <returns></returns>
    public double Income
    {
      get
      {
        return _income;
      }
      set
      {
        _income = value;
        IncomeChanged?.Invoke(this, new FactionEventArgs(this));
      }
    }

    /// <summary>
    /// Which Team this Faction currently belongs to. Determines a player's allies.
    /// </summary>
    public Team Team
    {
      get
      {
        return _team;
      }
      set
      {
        _team = value;
        TeamChanged?.Invoke(this, new FactionTeamChangedEventArgs());
      }
    }

    /// <summary>
    /// Faction's name that appears in user interface.
    /// </summary>
    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
        NameChanged?.Invoke(this, new FactionEventArgs(this));
      }
    }

    /// <summary>
    /// The string that goes before the faction's name to color it.
    /// </summary>
    public string PrefixColor
    {
      get;
    }

    /// <summary>
    /// Faction's name with a color prefix.
    /// </summary>
    public string ColoredName
    {
      get
      {
        return PrefixColor + Name;
      }
    }

    /// <summary>
    /// The icon that renders on the multiboard.
    /// </summary>
    public string Icon { 
      get {
        return _icon;
      } 
      set
      {
        _icon = value;
        IconChanged?.Invoke(this, new FactionEventArgs(this));
      }
    }
    
    /// <summary>
    /// Number of Control Points this player has.
    /// </summary>
    public int ControlPoints { get; private set; }

    /// <summary>
    /// Player currently occupying this Faction.
    /// </summary>
    public player Player
    {
      get
      {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// Person currently occupying this Faction.
    /// </summary>
    public Person Person
    {
      get
      {
        throw new NotImplementedException();
      }
      set
      {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// Quest that pops up for this Faction early on as an introduction.
    /// </summary>
    public QuestEx StartingQuest
    {
      get;
      set;
    }

    /// <summary>
    /// Music that plays when this team wins the game.
    /// </summary>
    public string VictoryMusic { get; set; }

    /// <summary>
    /// Whether or not this Faction can be invited to join a team.
    /// </summary>
    public virtual bool CanBeInvited {
      get
      {
        return true;
      }
    }

    /// <summary>
    /// The WC3 player color of this faction in-game.
    /// </summary>
    public playercolor PlayerColor
    {
      get
      {
        return _playercolor;
      }
      set
      {
        _playercolor = value;
        SetPlayerColor(Player, _playercolor);
      }
    }

    /// <summary>
    /// Adds a Quest to this Faction's quest log.
    /// </summary>
    /// <param name="quest"></param>
    public void AddQuest(QuestEx quest)
    {
      _quests.Add(quest);
      QuestAdded?.Invoke(this, new FactionQuestAddedEventArgs());
    }

    /// <summary>
    /// Sets the research level of an object to a value.
    /// </summary>
    public void SetObjectLevel(int obj, int level)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Changes this Faction's research or unit limit by a provided value.
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="limit"></param>
    public void ModObjectLimit(int obj, int limit)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Causes a Faction's player to lose all units and resources.
    /// </summary>
    public void Obliterate()
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Causes a Faction's player to distribute all units and resources amongst allies.
    /// </summary>
    public void Leave()
    {
      throw new NotImplementedException();
    }

    private double _excessGold = 0;
    private Team _team;
    private double _income = 0;
    private int _weight;
    private string _name;
    private string _icon;
    private playercolor _playercolor;
    private readonly List<QuestEx> _quests = new();
  }
}