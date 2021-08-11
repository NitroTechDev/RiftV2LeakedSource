// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Enums.LogType
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using System.ComponentModel;

namespace Rift.Frontend.Enums
{
  public enum LogType
  {
    [Description("INFO")] Information,
    [Description("WARN")] Warning,
    [Description("FAIL")] Error,
    [Description("STOP")] Exception,
  }
}
