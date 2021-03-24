﻿using System.Collections.Generic;
using War3Net.Build;
using War3Net.IO.Mpq;

namespace AzerothWarsCSharp.Launcher
{
  internal static class CompilerOptions
  {
    public static ScriptCompilerOptions GetCompilerOptions(string sourceDirectory, string outputDirectory)
    {
      var dict = new Dictionary<string, int>();

      var scriptCompilerOptions = new ScriptCompilerOptions(CSharpLua.CoreSystem.CoreSystemProvider.GetCoreSystemFiles())
      {
        MapInfo = Info.GetMapInfo()
      };
      scriptCompilerOptions.MapEnvironment = Info.GetMapEnvironment(scriptCompilerOptions.MapInfo);

      scriptCompilerOptions.SourceDirectory = sourceDirectory;
      scriptCompilerOptions.OutputDirectory = outputDirectory;

      scriptCompilerOptions.DefaultFileFlags = MpqFileFlags.Exists | MpqFileFlags.CompressedMulti;
      scriptCompilerOptions.FileFlags[ListFile.FileName] = MpqFileFlags.Exists | MpqFileFlags.CompressedMulti | MpqFileFlags.Encrypted | MpqFileFlags.BlockOffsetAdjustedKey;

#if DEBUG
      scriptCompilerOptions.Debug = true;
#endif

      return scriptCompilerOptions;
    }
  }
}