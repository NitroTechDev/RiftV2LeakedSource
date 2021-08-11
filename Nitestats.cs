// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Models.Nitestats
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Newtonsoft.Json;

namespace Rift.Frontend.Models
{
  public static class Nitestats
  {
    public class FlToken
    {
      [JsonProperty("version")]
      public string Version { get; set; }

      [JsonProperty("fltoken")]
      public string Token { get; set; }
    }
  }
}
