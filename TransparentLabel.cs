// Decompiled with JetBrains decompiler
// Type: TransparentLabel
// Assembly: YAMATAIPatch R4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5B3BBAAE-6003-4740-8AF6-CC1446CB3A90
// Assembly location: F:\Download\Compressed\yamatai4 (2)\YAMATAIPatch R4.exe

using System.Windows.Forms;

public class TransparentLabel : Label
{
  public TransparentLabel()
  {
    this.SetStyle(ControlStyles.Opaque, true);
    this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
  }

  protected override CreateParams CreateParams
  {
    get
    {
      CreateParams createParams = base.CreateParams;
      createParams.ExStyle |= 32;
      return createParams;
    }
  }
}
