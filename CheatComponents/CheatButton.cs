// Decompiled with JetBrains decompiler
// Type: CheatComponents.CheatButton
// Assembly: YAMATAIPatch R4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5B3BBAAE-6003-4740-8AF6-CC1446CB3A90
// Assembly location: F:\Download\Compressed\yamatai4 (2)\YAMATAIPatch R4.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace CheatComponents
{
    public class CheatButton : Button
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 256;
        public uint hotkey;
        public uint controlKey;
        public string nameString = " Hotkey! ";
        public string ID = "empty";
        public Button myButton;
        public CheckBox myCheckBox;
        public TextBox myEditBox;
        public bool hotkeyMode;
        public bool hasCheckBox = true;
        public List<string> ClickStrings;
        public List<string> EnableStrings;
        public List<string> DisableStrings;
        private static Color _back = Color.Gray;
        private static Color _border = Color.Black;
        public static List<CheatButton> buttonList = new List<CheatButton>();
        public static RichTextBox saveBox;
        public static bool hookInstalled = false;
        private static CheatButton.LowLevelKeyboardProc _proc = new CheatButton.LowLevelKeyboardProc(CheatButton.HookCallback);
        private static IntPtr _hookID = IntPtr.Zero;
        public static Label sLabel;

        public CheatButton(string _ID, string _nameString)
        {
            this.ID = _ID;
            this.nameString = _nameString;
            this.init();
        }

        public CheatButton(
          string _ID,
          string _nameString,
          List<string> _ClickStrings,
          List<string> _EnableStrings,
          List<string> _DisableStrings)
        {
            this.ID = _ID;
            this.nameString = _nameString;
            this.attachCheats(_ClickStrings, _EnableStrings, _DisableStrings);
            this.init();
        }

        public void attachCheats(
          List<string> _ClickStrings,
          List<string> _EnableStrings,
          List<string> _DisableStrings)
        {
            this.ClickStrings = _ClickStrings;
            this.EnableStrings = _EnableStrings;
            this.DisableStrings = _DisableStrings;
        }

        public CheatButton() => this.init();

        public void init()
        {
            this.InitializeComponent();
            this.hotkey = 0U;
            this.controlKey = 0U;
            this.Width = 200;
            this.Height = 40;
            CheatButton.buttonList.Add(this);
            this.addmyButton();
            this.addmyCheckBox();
            this.addMyEditBox();
            this.setColor();
            this.addListeners();
            CheatButton.Hookey();
            this.mode_normal();
            CheatButton.saveBox = main.sBox;
            this.FlatAppearance.BorderColor = CheatButton._back;
            this.FlatStyle = FlatStyle.Flat;
            this.myButton.FlatAppearance.BorderColor = CheatButton._back;
            this.myButton.FlatStyle = FlatStyle.Flat;
            if (this.myCheckBox == null)
                return;
            this.myCheckBox.FlatAppearance.BorderColor = CheatButton._back;
            this.myCheckBox.FlatStyle = FlatStyle.Flat;
        }

        public void addListeners()
        {
            this.Click += new EventHandler(this.self_click);
            this.myButton.Click += new EventHandler(this.hotkey_click);
            if (!this.hasCheckBox)
                return;
            this.myCheckBox.Click += new EventHandler(this.self_click);
        }

        public void setColor()
        {
            if (this.hasCheckBox)
            {
                if (this.myCheckBox.Checked)
                {
                    this.ForeColor = ColorTranslator.FromOle(34816);
                    this.BackColor = this.BackColor;
                }
                else
                {
                    this.ForeColor = ColorTranslator.FromOle(0);
                    this.BackColor = this.BackColor;
                }
            }
            else
            {
                this.ForeColor = ColorTranslator.FromOle(0);
                this.BackColor = this.BackColor;
            }
        }

        public void updateName()
        {
            string str1 = this.hotkeyMode ? "Shortcut keys:" : this.nameString;
            string str2 = "";
            if (this.controlKey > 0U)
                str2 = str2 + ((Keys)this.controlKey).ToString() + "+";
            if (this.hotkey > 0U)
                str2 += ((Keys)this.hotkey).ToString();
            if (this.hotkey > 0U)
                str2 = "\n" + str2;
            this.Text = str1 + str2;
        }

        private void self_click(object sender, EventArgs e)
        {
            this.addText("Processing click..." + this.Text);
            if (this.hasCheckBox)
            {
                this.myCheckBox.Checked = !this.myCheckBox.Checked;
                this.setColor();
                if (this.myCheckBox.Checked)
                    this.doClickAction(this.EnableStrings);
                else
                    this.doClickAction(this.DisableStrings);
            }
            if (this.ClickStrings != null)
                this.doClickAction(this.ClickStrings);
            this.Invalidate();
        }

        public void fillEditBox()
        {
            if (this.ClickStrings == null || this.ClickStrings.Count <= 0)
                return;
            for (int index = 0; index < this.ClickStrings.Count; ++index)
            {
                if (this.ClickStrings[index][0] == '@')
                    this.myEditBox.Text = this.ClickStrings[index].Split('@')[2];
            }
        }

        public void doClickAction(List<string> inStrings)
        {
            if (inStrings == null || inStrings.Count <= 0)
                return;
            for (int index = 0; index < inStrings.Count; ++index)
            {
                if (this.Parent != null)
                {
                    main.lastButton = this;
                    main.staticSelf.showButtonPanel();
                }
                if (inStrings[index][0] == '|')
                {
                    string[] strArray = inStrings[index].Split('|');
                    GameConnector.writeString((IntPtr)(long)uint.Parse(strArray[1], NumberStyles.AllowHexSpecifier), strArray[2]);
                }
                if (inStrings[index][0] == '@')
                {
                    string[] strArray = inStrings[index].Split('@');
                    string inName = strArray[1];
                    string inParam1 = this.myEditBox != null ? this.myEditBox.Text : strArray[2];
                    string inParam2 = strArray[3];
                    main.staticSelf.functionCall(inName, inParam1, inParam2);
                }
            }
            this.drawMyString();
        }

        public void drawMyString() => GameOverlay.drawString(this.myCheckBox == null ? (this.myEditBox == null ? this.nameString : this.nameString + " : " + this.myEditBox.Text) : this.nameString + " : " + (this.myCheckBox.Checked ? "Enabled" : "Disabled"));

        private void hotkey_click(object sender, EventArgs e)
        {
            this.addText("Hotkey Click!");
            if (this.hotkeyMode)
                this.mode_normal();
            else
                this.mode_hotkey();
        }

        public void mode_hotkey()
        {
            this.hotkeyMode = true;
            this.myButton.Text = "OK.";
            this.updateName();
            main.status(" [Esc] to clear keybind ");
        }

        public void mode_normal()
        {
            if (this.hotkeyMode)
                main.status(" Keybind Saved ");
            this.hotkeyMode = false;
            this.myButton.Text = "...";
            this.updateName();
        }

        public void addText(string inString) => main.addText(inString);

        public void hotkeyPressed(uint keyVal)
        {
            if (!GameHooks.hotkeysDisabled)
                this.self_click((object)null, (EventArgs)null);
            this.addText("yeah, hotkey pressed" + keyVal.ToString());
        }

        public void setHotkey(uint keyVal)
        {
            if (27U != keyVal)
            {
                this.addText("Setting my hotkey" + keyVal.ToString());
                this.hotkey = keyVal;
                this.controlKey = (uint)Control.ModifierKeys;
            }
            else
            {
                this.hotkey = 0U;
                this.controlKey = 0U;
            }
            this.updateName();
            CheatButton.saveHotkeys();
        }

        public Font getFont() => new Font(FontFamily.GenericSansSerif, 10f);

        public void addmyButton()
        {
            this.myButton = new Button();
            this.myButton.Width = 40;
            this.myButton.Height = 30;
            this.myButton.Left = this.Width - this.myButton.Width - 5;
            this.myButton.Top = this.Height / 2 - this.myButton.Height / 2;
            this.myButton.Text = "...";
            this.myButton.Font = this.getFont();
            this.Controls.Add((Control)this.myButton);
        }

        public void addMyEditBox()
        {
            if (this.ID.IndexOf("spawnButton") <= -1 && this.ID.IndexOf("btn_edit_") <= -1)
                return;
            this.myEditBox = new TextBox();
            this.myEditBox.Width = 60;
            this.myEditBox.Height = 30;
            this.myEditBox.Left = 5;
            this.myEditBox.Top = this.Height / 2 - this.myEditBox.Height / 2;
            this.myEditBox.Text = "06";
            this.myEditBox.TextAlign = HorizontalAlignment.Center;
            this.Controls.Add((Control)this.myEditBox);
            this.fillEditBox();
        }

        public void addmyCheckBox()
        {
            this.hasCheckBox = this.EnableStrings != null && this.EnableStrings.Count > 0;
            if (!this.hasCheckBox)
                return;
            this.myCheckBox = new CheckBox();
            this.myCheckBox.Width = 14;
            this.myCheckBox.Height = 14;
            this.myCheckBox.Left = 5;
            this.myCheckBox.Top = this.Height / 2 - this.myCheckBox.Height / 2;
            this.Controls.Add((Control)this.myCheckBox);
            this.myCheckBox.Enabled = false;
        }

        public static void saveHotkeys()
        {
            string str = "";
            if (CheatButton.buttonList.Count <= 0)
                return;
            for (int index = 0; index < CheatButton.buttonList.Count; ++index)
            {
                CheatButton button = CheatButton.buttonList[index];
                str = str + "|" + button.ID + "," + button.hotkey.ToString() + "," + button.controlKey.ToString();
            }
            CheatButton.saveBox.Text = str;
            CheatButton.saveBox.SaveFile("Keybinds.dat");
        }

        public static void loadHotkeys()
        {
            CheatButton.saveBox.LoadFile("Keybinds.dat");
            string text = CheatButton.saveBox.Text;
            if (text.Length <= 0)
                return;
            string str1 = text;
            char[] chArray1 = new char[1] { '|' };
            foreach (string str2 in str1.Split(chArray1))
            {
                char[] chArray2 = new char[1] { ',' };
                string[] strArray = str2.Split(chArray2);
                for (int index = 0; index < CheatButton.buttonList.Count; ++index)
                {
                    CheatButton button = CheatButton.buttonList[index];
                    if (button.ID == strArray[0])
                    {
                        button.hotkey = uint.Parse(strArray[1]);
                        button.controlKey = uint.Parse(strArray[2]);
                        button.updateName();
                    }
                }
            }
        }

        public static bool anyEditing()
        {
            bool flag = false;
            for (int index = 0; index < CheatButton.buttonList.Count; ++index)
            {
                if (CheatButton.buttonList[index] != null && CheatButton.buttonList[index].hotkeyMode)
                    flag = true;
            }
            return flag;
        }

        public static void Hookey()
        {
            if (CheatButton.hookInstalled)
                return;
            CheatButton._hookID = CheatButton.SetHook(CheatButton._proc);
            CheatButton.hookInstalled = true;
        }

        private static IntPtr SetHook(CheatButton.LowLevelKeyboardProc proc)
        {
            using (Process currentProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule mainModule = currentProcess.MainModule)
                    return CheatButton.SetWindowsHookEx(13, proc, CheatButton.GetModuleHandle(mainModule.ModuleName), 0U);
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)256)
            {
                uint keyVal = (uint)Marshal.ReadInt32(lParam);
                if (Control.ModifierKeys != 0)
                    main.sLabel.Text = Control.ModifierKeys.ToString() + " " + ((Keys)keyVal).ToString();
                else
                    main.sLabel.Text = ((Keys)keyVal).ToString();
                for (int index = 0; index < CheatButton.buttonList.Count; ++index)
                {
                    CheatButton button = CheatButton.buttonList[index];
                    if (button.hotkeyMode)
                        button.setHotkey(keyVal);
                    else if (!CheatButton.anyEditing() && button.hotkey > 0U && (int)button.hotkey == (int)keyVal && Control.ModifierKeys == (Keys)button.controlKey)
                        button.hotkeyPressed(keyVal);
                }
            }
            return CheatButton.CallNextHookEx(CheatButton._hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(
          int idHook,
          CheatButton.LowLevelKeyboardProc lpfn,
          IntPtr hMod,
          uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(
          IntPtr hhk,
          int nCode,
          IntPtr wParam,
          IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        [DllImport("kernel32.dll")]
        public static extern void SetLastError(uint dwErrorCode);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(
          IntPtr hProcess,
          IntPtr lpAddress,
          uint dwSize,
          CheatButton.AllocationType flAllocationType,
          CheatButton.MemoryProtection flProtect);

        [DllImport("kernel32.dll")]
        public static extern int CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(
          uint dwDesiredAccess,
          int bInheritHandle,
          uint dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern int WriteProcessMemory(
          IntPtr hProcess,
          IntPtr lpBaseAddress,
          byte[] lpBuffer,
          uint nSize,
          IntPtr lpNumberOfBytesWritten);

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Cursor = Cursors.Hand;
            this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ResumeLayout(false);
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [Flags]
        public enum ProcessAccessFlags : uint
        {
            All = 2035711, // 0x001F0FFF
            Terminate = 1,
            CreateThread = 2,
            VMOperation = 8,
            VMRead = 16, // 0x00000010
            VMWrite = 32, // 0x00000020
            DupHandle = 64, // 0x00000040
            SetInformation = 512, // 0x00000200
            QueryInformation = 1024, // 0x00000400
            Synchronize = 1048576, // 0x00100000
        }

        [Flags]
        public enum AllocationType
        {
            Commit = 4096, // 0x00001000
            Reserve = 8192, // 0x00002000
            Decommit = 16384, // 0x00004000
            Release = 32768, // 0x00008000
            Reset = 524288, // 0x00080000
            Physical = 4194304, // 0x00400000
            TopDown = 1048576, // 0x00100000
            WriteWatch = 2097152, // 0x00200000
            LargePages = 536870912, // 0x20000000
        }

        [Flags]
        public enum MemoryProtection
        {
            Execute = 16, // 0x00000010
            ExecuteRead = 32, // 0x00000020
            ExecuteReadWrite = 64, // 0x00000040
            ExecuteWriteCopy = 128, // 0x00000080
            NoAccess = 1,
            x02 = 2,
            ReadWrite = 4,
            WriteCopy = 8,
            GuardModifierflag = 256, // 0x00000100
            NoCacheModifierflag = 512, // 0x00000200
            WriteCombineModifierflag = 1024, // 0x00000400
        }
    }
}
