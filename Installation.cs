// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Models.Config.Installation
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using System.Text.Json.Serialization;

namespace Rift.Frontend.Models.Config
{
  public class Installation
  {
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("id")]
    public string Id => this.Name.ToLower().Replace(" ", "-");
  }
}
