﻿using System;

using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools
{
  public sealed class TimerWrapper : IDisposable
  {
    private readonly timer _timer = CreateTimer();

    public void Start(float timeout, bool periodic, Action handlerFunc)
    {
      TimerStart(_timer, timeout, periodic, handlerFunc);
    }

    ~TimerWrapper()
    {
      Dispose(false);
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing)
    {
      if (disposing)
      {
        DestroyTimer(_timer);
      }
    }
  }
}