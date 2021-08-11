// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Utilities.ConsoleCommands
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Microsoft.JSInterop;
using System.Threading.Tasks;


#nullable enable
namespace Rift.Frontend.Utilities
{
  public static class ConsoleCommands
  {
    [JSInvokable("hammer")]
    public static async 
    #nullable disable
    Task Hammer() => await Rift.Frontend.Utilities.Hammer.Patch();
  }
}
