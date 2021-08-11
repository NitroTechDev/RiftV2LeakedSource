// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Models.Config.Configuration
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rift.Frontend.Models.Config
{
  public class Configuration
  {
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    [JsonPropertyName("launchArgs")]
    public string LaunchArgs { get; set; }

    [JsonPropertyName("installs")]
    public List<Installation> Installations { get; set; } = new List<Installation>();
  }
}
