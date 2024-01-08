// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Program
// Assembly: YAMATAIPatch R4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5B3BBAAE-6003-4740-8AF6-CC1446CB3A90
// Assembly location: F:\Download\Compressed\yamatai4 (2)\YAMATAIPatch R4.exe

using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}
