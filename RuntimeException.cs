// Decompiled with JetBrains decompiler
// Type: Rift.Frontend.Exceptions.RuntimeException
// Assembly: Rift, Version=2.1.0.1, Culture=neutral, PublicKeyToken=null
// MVID: BECBAAF2-CE22-4091-BFA2-8285CB5B1EF4
// Assembly location: C:\Users\ca297\Desktop\Rift\Rift.dll

using System;

namespace Rift.Frontend.Exceptions
{
  public class RuntimeException : Exception
  {
    public RuntimeException()
      : base("Failed to start Runtime!")
    {
    }
  }
}
