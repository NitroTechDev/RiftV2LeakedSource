// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Pages.Static.Stylesheets
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Rift.Frontend.Services;

namespace Rift.Frontend.Pages.Static
{
  public class Stylesheets : ComponentBase
  {
    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
      __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"css/app.css\">\r\n<link rel=\"stylesheet\" href=\"css/mods.css\">\r\n<link rel=\"stylesheet\" href=\"css/fontawesome.css\">\r\n\r\n");
      if (!this._configService.RequireFirstTimeSetup)
        return;
      __builder.AddMarkupContent(1, "    <link rel=\"stylesheet\" href=\"css/fts.css\">\r\n");
    }

    [Inject]
    private ConfigService _configService { get; set; }
  }
}
