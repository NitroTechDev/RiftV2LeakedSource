// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Pages.FirstTimeSetup.FtsName
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Rift.Frontend.Services;
using System;

namespace Rift.Frontend.Pages.FirstTimeSetup
{
  public class FtsName : ComponentBase
  {
    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
      __builder.OpenElement(0, "div");
      __builder.AddAttribute(1, "class", "fts-page");
      __builder.AddAttribute(2, "id", "fts-name");
      __builder.AddAttribute(3, "style", "display: none");
      __builder.AddMarkupContent(4, "\r\n    ");
      __builder.AddMarkupContent(5, "<div class=\"text\">\r\n        <h1>What's your name?</h1>\r\n        <h3>You can always change this later in the settings.</h3>\r\n    </div>\r\n    ");
      __builder.OpenElement(6, "div");
      __builder.AddAttribute(7, "class", "content");
      __builder.AddMarkupContent(8, "\r\n        ");
      __builder.OpenElement(9, "div");
      __builder.AddAttribute(10, "class", "input-block");
      __builder.AddMarkupContent(11, "\r\n            ");
      __builder.OpenElement(12, "input");
      __builder.AddAttribute(13, "placeholder", "Pick a cool name!");
      __builder.AddAttribute(14, "oninput", "rift.fts.utils.validateBtn(this, 'fts-name-next', 16)");
      __builder.AddAttribute(15, "maxlength", "16");
      __builder.AddAttribute(16, "value", BindConverter.FormatValue(this._configService.Configuration.DisplayName));
      __builder.AddAttribute<ChangeEventArgs>(17, "onchange", EventCallback.Factory.CreateBinder((object) this, (Action<string>) (__value => this._configService.Configuration.DisplayName = __value), this._configService.Configuration.DisplayName));
      __builder.SetUpdatesAttributeName("value");
      __builder.CloseElement();
      __builder.AddMarkupContent(18, "\r\n            ");
      __builder.AddMarkupContent(19, "<span class=\"label\">Pick a cool name!</span>\r\n        ");
      __builder.CloseElement();
      __builder.AddMarkupContent(20, "\r\n        ");
      __builder.AddMarkupContent(21, "<button id=\"fts-name-next\" onclick=\"rift.fts.steps.nextStep(this)\">Next</button>\r\n    ");
      __builder.CloseElement();
      __builder.AddMarkupContent(22, "\r\n");
      __builder.CloseElement();
    }

    [Inject]
    private ConfigService _configService { get; set; }
  }
}
