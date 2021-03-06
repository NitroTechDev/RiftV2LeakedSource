// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Models.QueuedLog
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Rift.Frontend.Enums;

namespace Rift.Frontend.Models
{
  public readonly struct QueuedLog
  {
    public readonly string Message;
    public readonly LogCategory Category;
    public readonly LogType Type;

    public QueuedLog(string message, LogCategory category, LogType type)
    {
      this.Message = message;
      this.Category = category;
      this.Type = type;
    }
  }
}
