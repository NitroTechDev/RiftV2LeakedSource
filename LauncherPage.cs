// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Pages.LauncherPage.LauncherPage
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Rift.Frontend.Pages.LauncherPage.Tabs;

namespace Rift.Frontend.Pages.LauncherPage
{
  public class LauncherPage : ComponentBase
  {
    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
      __builder.OpenComponent<Sidebar>(0);
      __builder.CloseComponent();
      __builder.AddMarkupContent(1, "\r\n\r\n");
      __builder.OpenElement(2, "div");
      __builder.AddAttribute(3, "class", "tab-container");
      __builder.AddMarkupContent(4, "\r\n    ");
      __builder.OpenComponent<PlayTab>(5);
      __builder.CloseComponent();
      __builder.AddMarkupContent(6, "\r\n    ");
      __builder.OpenComponent<SettingsTab>(7);
      __builder.CloseComponent();
      __builder.AddMarkupContent(8, "\r\n    ");
      __builder.OpenComponent<Rift.Frontend.Pages.LauncherPage.Tabs.ModsTab.ModsTab>(9);
      __builder.CloseComponent();
      __builder.AddMarkupContent(10, "\r\n    ");
      __builder.OpenComponent<InfoTab>(11);
      __builder.CloseComponent();
      __builder.AddMarkupContent(12, "\r\n");
      __builder.CloseElement();
      __builder.AddMarkupContent(13, "\r\n\r\n");
      __builder.OpenComponent<ChangelogModal>(14);
      __builder.CloseComponent();
      __builder.AddMarkupContent(15, "\r\n");
      __builder.OpenComponent<UpdateModal>(16);
      __builder.CloseComponent();
      __builder.AddMarkupContent(17, "\r\n");
      __builder.OpenComponent<WarningModal>(18);
      __builder.CloseComponent();
    }
  }
}
