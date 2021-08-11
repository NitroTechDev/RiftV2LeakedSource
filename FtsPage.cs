// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Pages.FirstTimeSetup.FtsPage
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Rift.Frontend.Pages.FirstTimeSetup
{
  public class FtsPage : ComponentBase
  {
    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
      __builder.OpenElement(0, "div");
      __builder.AddAttribute(1, "class", "center-container");
      __builder.AddMarkupContent(2, "\r\n    ");
      __builder.OpenComponent<FtsWelcome>(3);
      __builder.CloseComponent();
      __builder.AddMarkupContent(4, "\r\n    ");
      __builder.OpenComponent<FtsName>(5);
      __builder.CloseComponent();
      __builder.AddMarkupContent(6, "\r\n    ");
      __builder.OpenComponent<FtsBuild>(7);
      __builder.CloseComponent();
      __builder.AddMarkupContent(8, "\r\n    ");
      __builder.AddMarkupContent(9, "<div class=\"fts-page\" id=\"fts-final\" style=\"display: none\">\r\n        <div class=\"text\">\r\n            <h1>All done!</h1>\r\n            <h3>Enjoy Rift!</h3>\r\n        </div>\r\n    </div>\r\n");
      __builder.CloseElement();
    }
  }
}
