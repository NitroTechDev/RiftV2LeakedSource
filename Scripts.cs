// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Pages.Static.Scripts
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Rift.Frontend.Services;

namespace Rift.Frontend.Pages.Static
{
  public class Scripts : ComponentBase
  {
    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
      if (this._configService.RequireFirstTimeSetup)
      {
        __builder.AddContent(0, "    ");
        __builder.OpenElement(1, "script");
        __builder.AddAttribute(2, "src", "/js/fts.js");
        __builder.CloseElement();
        __builder.AddMarkupContent(3, "\r\n");
      }
      else
      {
        __builder.AddContent(4, "    ");
        __builder.OpenElement(5, "script");
        __builder.AddAttribute(6, "src", "/js/utils.js");
        __builder.CloseElement();
        __builder.AddMarkupContent(7, "\r\n    ");
        __builder.OpenElement(8, "script");
        __builder.AddAttribute(9, "src", "/js/tabManager.js");
        __builder.CloseElement();
        __builder.AddMarkupContent(10, "\r\n    ");
        __builder.OpenElement(11, "script");
        __builder.AddAttribute(12, "src", "/js/modalManager.js");
        __builder.CloseElement();
        __builder.AddMarkupContent(13, "\r\n    ");
        __builder.OpenElement(14, "script");
        __builder.AddAttribute(15, "src", "/js/contextMenu.js");
        __builder.CloseElement();
        __builder.AddMarkupContent(16, "\r\n    ");
        __builder.OpenElement(17, "script");
        __builder.AddAttribute(18, "src", "/js/modsLanding.js");
        __builder.CloseElement();
        __builder.AddMarkupContent(19, "\r\n    ");
        __builder.OpenElement(20, "script");
        __builder.AddAttribute(21, "src", "/js/modsMenu.js");
        __builder.CloseElement();
        __builder.AddMarkupContent(22, "\r\n");
      }
    }

    [Inject]
    private ConfigService _configService { get; set; }
  }
}
