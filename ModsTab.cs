// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Pages.LauncherPage.Tabs.ModsTab.ModsTab
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Rift.Frontend.Pages.LauncherPage.Tabs.ModsTab.Pages;
using Rift.Frontend.Services;

namespace Rift.Frontend.Pages.LauncherPage.Tabs.ModsTab
{
  public class ModsTab : ComponentBase
  {
    public static bool EnableModMenu;

    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
      __builder.OpenElement(0, "script");
      __builder.AddAttribute(1, "src", "https://cdn.jsdelivr.net/npm/canvas-confetti@1.4.0/dist/confetti.browser.min.js");
      __builder.CloseElement();
      __builder.AddMarkupContent(2, "\r\n\r\n");
      __builder.OpenElement(3, "div");
      __builder.AddAttribute(4, "id", "mods-page");
      __builder.AddAttribute(5, "style", "display: none;");
      __builder.AddMarkupContent(6, "\r\n");
      if (Rift.Frontend.Pages.LauncherPage.Tabs.ModsTab.ModsTab.EnableModMenu)
      {
        __builder.AddContent(7, "        ");
        __builder.AddMarkupContent(8, "<div class=\"header\">\r\n            <label class=\"container active\" id=\"myMods-radio\">My Mods\r\n                <input type=\"radio\" checked=\"checked\" onclick=\"rift.modsMenu.setTab('myMods')\" name=\"tabSwitcher\">\r\n                <span class=\"checkmark\"></span>\r\n            </label>\r\n            <label class=\"container\" id=\"marketplace-radio\">Explore\r\n                <input type=\"radio\" onclick=\"rift.modsMenu.setTab('marketplace')\" name=\"tabSwitcher\">\r\n                <span class=\"checkmark\"></span>\r\n            </label>\r\n            <label class=\"container\" id=\"preferences-radio\">Preferences\r\n                <input type=\"radio\" onclick=\"rift.modsMenu.setTab('preferences')\" name=\"tabSwitcher\">\r\n                <span class=\"checkmark\"></span>\r\n            </label>\r\n        </div>\r\n        ");
        __builder.OpenElement(9, "div");
        __builder.AddAttribute(10, "class", "container");
        __builder.AddMarkupContent(11, "\r\n            ");
        __builder.OpenComponent<MyModsPage>(12);
        __builder.CloseComponent();
        __builder.AddMarkupContent(13, "\r\n            ");
        __builder.AddMarkupContent(14, "<div id=\"marketplace\" style=\"display: none\">\r\n                <h3>Marketplace</h3>\r\n            </div>\r\n            ");
        __builder.AddMarkupContent(15, "<div id=\"preferences\" style=\"display: none\">\r\n                <h3>Preferences</h3>\r\n            </div>\r\n        ");
        __builder.CloseElement();
        __builder.AddMarkupContent(16, "\r\n");
      }
      else
      {
        __builder.AddContent(17, "        ");
        __builder.AddMarkupContent(18, "<div class=\"mods-intro scale-in\">\r\n            <canvas id=\"confetti-canvas\" style=\"width: 100%; height: 100%\"></canvas>\r\n            <div class=\"icon\">\r\n                <i id=\"closedbox\" class=\"fas fa-box\"></i>\r\n                <i id=\"openbox\" class=\"fas fa-box-open\"></i>\r\n                <div class=\"explosion-circle\"></div>\r\n            </div>\r\n            <div class=\"text\">\r\n                <h1>Rift Mods</h1>\r\n                <h3>Coming soon</h3>\r\n            </div>\r\n        </div>\r\n");
      }
      __builder.CloseElement();
    }

    [Inject]
    private UpdateService _updateService { get; set; }
  }
}
