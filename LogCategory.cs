// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Enums.LogCategory
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using System.ComponentModel;

namespace Rift.Frontend.Enums
{
  public enum LogCategory
  {
    [Description("Debug.gray")] None,
    [Description("Configuration.#84d1fa")] ConfigurationService,
    [Description("Hammer.mediumspringgreen")] Patcher,
    [Description("Launcher.#fa84cf")] LauncherService,
    [Description("Discord.#848efa")] RichPresenceService,
    [Description("Updater.#faec84")] UpdaterService,
    [Description("Iron.#a19d94")] Injector,
  }
}
