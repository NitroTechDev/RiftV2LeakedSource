﻿// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Pages.LauncherPage.UpdateModal
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Rift.Frontend.Services;
using Rift.Frontend.Utilities;
using System;

namespace Rift.Frontend.Pages.LauncherPage
{
  public class UpdateModal : ComponentBase
  {
    public static bool EnableUpdateCheck = true;
    public static string ModalTitle = "Update available";
    public static string ModalDescription = "A new update ({0}) is available. Please download it from #download in our ";
    public static string ModalHyperlink = "Discord Server.";
    public static string ModalConfirm = "Okay";

    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
      __builder.OpenElement(0, "div");
      __builder.AddAttribute(1, "class", "modal " + this.MinimizedOrNot);
      __builder.AddAttribute(2, "id", "update-modal");
      __builder.AddMarkupContent(3, "\r\n\t");
      __builder.OpenElement(4, "div");
      __builder.AddAttribute(5, "class", "modal-window");
      __builder.AddAttribute(6, "style", "width: 490px");
      __builder.AddMarkupContent(7, "\r\n\t\t");
      __builder.AddMarkupContent(8, "<div class=\"close-button\" onclick=\"rift.modalManager.hideModal('update')\">\r\n\t\t\t<i class=\"fas fa-times\"></i>\r\n\t\t</div>\r\n\t\t");
      __builder.OpenElement(9, "div");
      __builder.AddAttribute(10, "class", "modal-header");
      __builder.AddMarkupContent(11, "\r\n\t\t\t");
      __builder.OpenElement(12, "h1");
      __builder.AddAttribute(13, "class", "modal-title");
      __builder.AddContent(14, UpdateModal.ModalTitle);
      __builder.CloseElement();
      __builder.AddMarkupContent(15, "\r\n\t\t\t");
      __builder.OpenElement(16, "p");
      __builder.AddAttribute(17, "class", "modal-desc");
      __builder.AddContent(18, string.Format(UpdateModal.ModalDescription, (object) UpdateService.LatestVersion));
      __builder.AddContent(19, " ");
      __builder.OpenElement(20, "span");
      __builder.AddAttribute(21, "class", "hyperlink");
      __builder.AddAttribute<MouseEventArgs>(22, "onclick", EventCallback.Factory.Create<MouseEventArgs>((object) this, (Action) (() => WindowsUtilities.OpenURL("https://discord.gg/riftfn"))));
      __builder.AddContent(23, UpdateModal.ModalHyperlink);
      __builder.CloseElement();
      __builder.CloseElement();
      __builder.AddMarkupContent(24, "\r\n\t\t");
      __builder.CloseElement();
      __builder.AddMarkupContent(25, "\r\n\t\t\r\n\t\t");
      __builder.OpenElement(26, "button");
      __builder.AddAttribute(27, "onclick", "rift.modalManager.hideModal('update')");
      __builder.AddContent(28, UpdateModal.ModalConfirm);
      __builder.CloseElement();
      __builder.AddMarkupContent(29, "\r\n\t");
      __builder.CloseElement();
      __builder.AddMarkupContent(30, "\r\n");
      __builder.CloseElement();
    }

    private string MinimizedOrNot => !UpdateModal.EnableUpdateCheck || !this._updateService.CheckForUpdates() ? "minimized" : "";

    [Inject]
    private UpdateService _updateService { get; set; }
  }
}
