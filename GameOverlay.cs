// Decompiled with JetBrains decompiler
// Type: GameOverlay
// Assembly: YAMATAIPatch R4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5B3BBAAE-6003-4740-8AF6-CC1446CB3A90
// Assembly location: F:\Download\Compressed\yamatai4 (2)\YAMATAIPatch R4.exe

using System;
using System.Drawing;
using System.Windows.Forms;
using Win32;
using WindowsFormsApplication1;

public class GameOverlay
{
  public static IntPtr dcSource;
  public static Graphics dcGraphics;
  public static SolidBrush bg = new SolidBrush(Color.Black);
  public static SolidBrush black = new SolidBrush(Color.Black);
  public static SolidBrush white = new SolidBrush(Color.White);
  public static string dcString;
  public static bool overlayEnabled = false;
  public static Label fontLabel;

  public static void tick()
  {
    GameOverlay.dcGraphics.DrawString(GameOverlay.dcString, GameOverlay.fontLabel.Font, (Brush) GameOverlay.black, (PointF) new Point(20, 20));
    GameOverlay.dcGraphics.DrawString(GameOverlay.dcString, GameOverlay.fontLabel.Font, (Brush) GameOverlay.white, (PointF) new Point(22, 22));
  }

  public static void setSourceFont(Label inLabel) => GameOverlay.fontLabel = inLabel;

  public static void drawString(string inString)
  {
    if (!GameConnector.gameFound || !GameOverlay.overlayEnabled)
      return;
    GameOverlay.dcString = inString;
    if (((IntPtr) User.FindWindow("TOMBRAIDER_WINDOW", (string) null)).ToInt32() <= 0)
      return;
    GameOverlay.dcGraphics = Graphics.FromHdc(GameOverlay.dcSource);
    if (GameOverlay.dcGraphics != null)
      GameOverlay.dcGraphics.Clear(Color.Transparent);
    main.staticSelf.start_blit_timer();
  }
}
