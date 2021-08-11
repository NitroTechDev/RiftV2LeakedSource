// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Pages.Static.Watermark
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Rift.Frontend.Utilities;

namespace Rift.Frontend.Pages.Static
{
  public class Watermark : ComponentBase
  {
    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
      __builder.OpenElement(0, "div");
      __builder.AddAttribute(1, "class", "watermark");
      __builder.AddAttribute(2, "onclick", "rift.tabManager.setTab('info')");
      __builder.AddMarkupContent(3, "\r\n    ");
      __builder.AddContent(4, Strings.VERSION_STRING);
      __builder.AddMarkupContent(5, "\r\n");
      __builder.CloseElement();
    }
  }
}
