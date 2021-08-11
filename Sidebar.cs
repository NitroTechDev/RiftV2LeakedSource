// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Pages.LauncherPage.Sidebar
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Rift.Frontend.Utilities;

namespace Rift.Frontend.Pages.LauncherPage
{
  public class Sidebar : ComponentBase
  {
    public static bool ModsTabEnabled = true;
    public static string PlayText = "Play";
    public static string SettingsText = "Settings";
    public static string InfoText = "Info";
    public static string ModsText = "Mods";
    public static string WarningText = "Warning";

    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
      __builder.OpenElement(0, "ul");
      __builder.AddAttribute(1, "class", "sidebar");
      __builder.AddMarkupContent(2, "\r\n    ");
      __builder.AddMarkupContent(3, "<div class=\"rift-header\">\r\n        <img src=\"/img/rift.png\" alt=\"Icon\">\r\n        <h1>Rift</h1>\r\n    </div>\r\n    ");
      __builder.OpenElement(4, "li");
      __builder.AddAttribute(5, "id", "play-li");
      __builder.AddAttribute(6, "class", "selected");
      __builder.AddAttribute(7, "onclick", "rift.tabManager.setTab('play')");
      __builder.AddMarkupContent(8, "\r\n        <i class=\"fas fa-play\"></i>");
      __builder.AddContent(9, Sidebar.PlayText);
      __builder.AddMarkupContent(10, "\r\n    ");
      __builder.CloseElement();
      __builder.AddMarkupContent(11, "\r\n    ");
      __builder.OpenElement(12, "li");
      __builder.AddAttribute(13, "id", "settings-li");
      __builder.AddAttribute(14, "onclick", "rift.tabManager.setTab('settings')");
      __builder.AddMarkupContent(15, "\r\n        <i class=\"fas fa-cog\"></i>");
      __builder.AddContent(16, Sidebar.SettingsText);
      __builder.AddMarkupContent(17, "\r\n    ");
      __builder.CloseElement();
      __builder.AddMarkupContent(18, "\r\n");
      if (Sidebar.ModsTabEnabled)
      {
        if (Rift.Frontend.Pages.LauncherPage.Tabs.ModsTab.ModsTab.EnableModMenu)
        {
          __builder.AddContent(19, "            ");
          __builder.OpenElement(20, "li");
          __builder.AddAttribute(21, "id", "mods-li");
          __builder.AddAttribute(22, "onclick", "rift.tabManager.setTab('mods');");
          __builder.AddMarkupContent(23, "\r\n                <i class=\"fas fa-box-open\"></i>");
          __builder.AddContent(24, Sidebar.ModsText);
          __builder.AddMarkupContent(25, "\r\n            ");
          __builder.CloseElement();
          __builder.AddMarkupContent(26, "\r\n");
        }
        else
        {
          __builder.AddContent(27, "            ");
          __builder.OpenElement(28, "li");
          __builder.AddAttribute(29, "id", "mods-li");
          __builder.AddAttribute(30, "onclick", "rift.tabManager.setTab('mods'); rift.modsLanding.animations.intro()");
          __builder.AddMarkupContent(31, "\r\n                <i class=\"fas fa-box-open\"></i>");
          __builder.AddContent(32, Sidebar.ModsText);
          __builder.AddMarkupContent(33, "\r\n            ");
          __builder.CloseElement();
          __builder.AddMarkupContent(34, "\r\n");
        }
      }
      __builder.AddContent(35, "    ");
      __builder.OpenElement(36, "li");
      __builder.AddAttribute(37, "id", "info-li");
      __builder.AddAttribute(38, "onclick", "rift.tabManager.setTab('info')");
      __builder.AddMarkupContent(39, "\r\n        <i class=\"fas fa-info\"></i>");
      __builder.AddContent(40, Sidebar.InfoText);
      __builder.AddMarkupContent(41, "\r\n    ");
      __builder.CloseElement();
      __builder.AddMarkupContent(42, "\r\n");
      if (EmergencyNotice.Enabled)
      {
        __builder.AddContent(43, "        ");
        __builder.OpenElement(44, "li");
        __builder.AddAttribute(45, "id", "emergency-li");
        __builder.AddAttribute(46, "class", "warn");
        __builder.AddAttribute(47, "onclick", "rift.modalManager.showModal('emergency')");
        __builder.AddMarkupContent(48, "\r\n            <i class=\"fas fa-exclamation-triangle\"></i>");
        __builder.AddContent(49, Sidebar.WarningText);
        __builder.AddMarkupContent(50, "\r\n        ");
        __builder.CloseElement();
        __builder.AddMarkupContent(51, "\r\n");
      }
      __builder.AddMarkupContent(52, "    \r\n");
      __builder.CloseElement();
    }
  }
}
