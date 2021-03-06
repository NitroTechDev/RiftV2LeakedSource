// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Pages.LauncherPage.WarningModal
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using Rift.Frontend.Utilities;

namespace Rift.Frontend.Pages.LauncherPage
{
  public class WarningModal : ComponentBase
  {
    public static bool ShowOnStartup = true;
    public static string ModalConfirm = "Okay";

    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
      __builder.OpenElement(0, "div");
      __builder.AddAttribute(1, "class", "modal " + this.MinimizedOrNot);
      __builder.AddAttribute(2, "id", "emergency-modal");
      __builder.AddMarkupContent(3, "\r\n\t");
      __builder.OpenElement(4, "div");
      __builder.AddAttribute(5, "class", "modal-window");
      __builder.AddAttribute(6, "style", "width: 490px");
      __builder.AddMarkupContent(7, "\r\n\t\t");
      __builder.AddMarkupContent(8, "<div class=\"close-button\" onclick=\"rift.modalManager.hideModal('emergency')\">\r\n\t\t\t<i class=\"fas fa-times\"></i>\r\n\t\t</div>\r\n\t\t");
      __builder.OpenElement(9, "div");
      __builder.AddAttribute(10, "class", "modal-header");
      __builder.AddMarkupContent(11, "\r\n\t\t\t");
      __builder.OpenElement(12, "h1");
      __builder.AddAttribute(13, "class", "modal-title");
      __builder.AddContent(14, EmergencyNotice.Title);
      __builder.CloseElement();
      __builder.AddMarkupContent(15, "\r\n\t\t\t");
      __builder.OpenElement(16, "p");
      __builder.AddAttribute(17, "class", "modal-desc");
      __builder.AddContent(18, EmergencyNotice.Message);
      __builder.CloseElement();
      __builder.AddMarkupContent(19, "\r\n\t\t");
      __builder.CloseElement();
      __builder.AddMarkupContent(20, "\r\n\t\t\r\n\t\t");
      __builder.OpenElement(21, "button");
      __builder.AddAttribute(22, "onclick", "rift.modalManager.hideModal('emergency')");
      __builder.AddContent(23, WarningModal.ModalConfirm);
      __builder.CloseElement();
      __builder.AddMarkupContent(24, "\r\n\t");
      __builder.CloseElement();
      __builder.AddMarkupContent(25, "\r\n");
      __builder.CloseElement();
    }

    private string MinimizedOrNot => !WarningModal.ShowOnStartup || !EmergencyNotice.Enabled ? "minimized" : "";

    [Inject]
    private IJSRuntime _jsRuntime { get; set; }
  }
}
