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
    // 실제로 트레이너 클릭시 사용하는 치트 버튼 (replace 함수에 의해 일반 버튼이 이 버튼으로 변경됨)
    // 윈폼 버튼을 상속함
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
        private static LowLevelKeyboardProc _proc = new LowLevelKeyboardProc(HookCallback);
        private static IntPtr _hookID = IntPtr.Zero;
        public static Label sLabel;

        public CheatButton(string _ID, string _nameString)
        {
            ID = _ID;
            nameString = _nameString;
            init();
        }

        public CheatButton(
          string _ID,
          string _nameString,
          List<string> _ClickStrings,
          List<string> _EnableStrings,
          List<string> _DisableStrings)
        {
            ID = _ID;
            nameString = _nameString;
            attachCheats(_ClickStrings, _EnableStrings, _DisableStrings);
            init();
        }

        public void attachCheats(
          List<string> _ClickStrings,
          List<string> _EnableStrings,
          List<string> _DisableStrings)
        {
            ClickStrings = _ClickStrings;
            EnableStrings = _EnableStrings;
            DisableStrings = _DisableStrings;
        }

        public CheatButton()
        {
            init();
        }

        public void init()
        {
            InitializeComponent();
            hotkey = 0U;
            controlKey = 0U;
            Width = 200;
            Height = 40;
            buttonList.Add(this);
            addmyButton();
            addmyCheckBox();
            addMyEditBox();
            setColor();
            add_event_listeners();
            Hookey();
            mode_normal();
            saveBox = main.sBox;
            FlatAppearance.BorderColor = _back;
            FlatStyle = FlatStyle.Flat;
            myButton.FlatAppearance.BorderColor = _back;
            myButton.FlatStyle = FlatStyle.Flat;
            if (myCheckBox == null)
                return;
            myCheckBox.FlatAppearance.BorderColor = _back;
            myCheckBox.FlatStyle = FlatStyle.Flat;
        }

        public void add_event_listeners()
        {
            Click += new EventHandler(self_trainer_item_click);
            myButton.Click += new EventHandler(hotkey_click);
            if (!hasCheckBox)
                return;
            myCheckBox.Click += new EventHandler(self_trainer_item_click);
        }

        public void setColor()
        {
            if (hasCheckBox)
            {
                if (myCheckBox.Checked)
                {
                    ForeColor = ColorTranslator.FromOle(34816);
                    BackColor = BackColor;
                }
                else
                {
                    ForeColor = ColorTranslator.FromOle(0);
                    BackColor = BackColor;
                }
            }
            else
            {
                ForeColor = ColorTranslator.FromOle(0);
                BackColor = BackColor;
            }
        }

        public void updateName()
        {
            string str1 = hotkeyMode ? "Shortcut keys:" : nameString;
            string str2 = "";
            if (controlKey > 0U)
                str2 = str2 + ((Keys)controlKey).ToString() + "+";
            if (hotkey > 0U)
                str2 += ((Keys)hotkey).ToString();
            if (hotkey > 0U)
                str2 = "\n" + str2;
            Text = str1 + str2;
        }

        // 트레이너 버튼 클릭시
        private void self_trainer_item_click(object sender, EventArgs e)
        {
            addText("Processing click..." + Text);

            // 체크박스가 있는 경우
            if (hasCheckBox)
            {
                myCheckBox.Checked = !myCheckBox.Checked;
                setColor();
                if (myCheckBox.Checked)
                    do_click_action(EnableStrings);
                else
                    do_click_action(DisableStrings);
            }
            if (ClickStrings != null)
                do_click_action(ClickStrings);

            /*
                Windows Forms는 렌더링을 위해 GDI를 사용합니다. GDI는 Windows의 원래 그래픽 인터페이스입니다.
                GDI 프로그램이 표시되는 내용을 업데이트하려고 할 때 업데이트된 이미지를 화면에 직접 그릴 수는 없습니다 . 
                대신 Windows에 영역을 업데이트해야 한다고 알려야 합니다. 이를 지역 무효화 라고 합니다. 
                그런 다음 Windows는 무엇이 유효하지 않고 업데이트가 필요한지에 대한 정보를 제공하는 관련 페인트 메서드를 호출합니다. 
                그런 다음 페인트 메서드는 업데이트된 내용을 화면에 그려야 합니다.

                Windows Forms에서는 컨트롤을 무효화(invalidate)할 때 컨트롤을 다시 그려야 한다고 요청합니다 .
                출처 : https://stackoverflow.com/questions/6425161/what-does-invalidate-method-do
             */
            Invalidate();
        }

        public void fillEditBox()
        {
            if (ClickStrings == null || ClickStrings.Count <= 0)
                return;
            for (int index = 0; index < ClickStrings.Count; ++index)
            {
                if (ClickStrings[index][0] == '@')
                    myEditBox.Text = ClickStrings[index].Split('@')[2];
            }
        }

        // 메모리 변조 처리 처리 함수 (by 트레이너 버튼 클릭)
        public async void do_click_action(List<string> inStrings)
        {
            // 게임이 아직 실행중이 아닌 상태에서 미리 메모리 변조를 처리하려고 할 경우
            if (!GameConnector.gameFound)
            {
                // 게임이 실행될때까지 대기했다가 메모리 변조 처리
                // 비동기적으로 프로세스가 실행될 때까지 기다림
                await WaitForProcessStartAsync(GameConnector.gameName + ".exe");
            }
            if (inStrings == null || inStrings.Count <= 0)
                return;

            for (int index = 0; index < inStrings.Count; ++index)
            {
                if (Parent != null)
                {
                    main.lastButton = this;
                    main.staticSelf.showButtonPanel();
                }
                if (inStrings[index][0] == '|')
                {
                    string[] strArray = inStrings[index].Split('|');
                    GameConnector.writeString((IntPtr)uint.Parse(strArray[1], NumberStyles.AllowHexSpecifier), strArray[2]);
                }
                if (inStrings[index][0] == '@')
                {
                    string[] strArray = inStrings[index].Split('@');
                    string inName = strArray[1];
                    string inParam1 = myEditBox != null ? myEditBox.Text : strArray[2];
                    string inParam2 = strArray[3];
                    main.staticSelf.functionCall(inName, inParam1, inParam2);
                }
            }
            drawMyString();
        }

        private async Task WaitForProcessStartAsync(string processName)
        {
            await Task.Run(() =>
            {
                // 프로세스가 실행될 때까지 대기
                while (!conditionMet)
                {
                    // optional: sleep을 추가하여 CPU 소비를 줄일 수 있음
                    Task.Delay(100).Wait();
                }

                // 특정 조건이 충족되면 프로세스 실행
                if (conditionMet)
                {
                    Process process = new Process();
                    process.StartInfo.FileName = processName;
                    process.Start();
                }
            });
        }

        public void drawMyString() => GameOverlay.drawString(myCheckBox == null ? (myEditBox == null ? nameString : nameString + " : " + myEditBox.Text) : nameString + " : " + (myCheckBox.Checked ? "Enabled" : "Disabled"));

        /*
        public void drawMyString()
        {
            if (myCheckBox != null)
            {
                string displayText = nameString + " : " + (myCheckBox.Checked ? "Enabled" : "Disabled");
                GameOverlay.drawString(displayText);
            }
            else
            {
                if (myEditBox == null)
                {
                    GameOverlay.drawString(nameString);
                }
                else
                {
                    string displayText = nameString;
                    if (!string.IsNullOrEmpty(myEditBox.Text))
                    {
                        displayText += " : " + myEditBox.Text;
                    }

                    GameOverlay.drawString(displayText);
                }
            }
        }
        */

        private void hotkey_click(object sender, EventArgs e)
        {
            addText("Hotkey Click!");
            if (hotkeyMode)
                mode_normal();
            else
                mode_hotkey();
        }

        public void mode_hotkey()
        {
            hotkeyMode = true;
            myButton.Text = "OK.";
            updateName();
            main.status(" [Esc] to clear keybind ");
        }

        public void mode_normal()
        {
            if (hotkeyMode)
                main.status(" Keybind Saved ");
            hotkeyMode = false;
            myButton.Text = "...";
            updateName();
        }

        public void addText(string inString)
        {
            main.addText(inString);
        }

        public void hotkeyPressed(uint keyVal)
        {
            if (!GameHooks.hotkeysDisabled)
                self_trainer_item_click(null, null);
            addText("yeah, hotkey pressed" + keyVal.ToString());
        }

        public void setHotkey(uint keyVal)
        {
            if (27U != keyVal)
            {
                addText("Setting my hotkey" + keyVal.ToString());
                hotkey = keyVal;
                controlKey = (uint)ModifierKeys;
            }
            else
            {
                hotkey = 0U;
                controlKey = 0U;
            }
            updateName();
            saveHotkeys();
        }

        public Font getFont()
        {
            return new Font(FontFamily.GenericSansSerif, 10f);
        }

        public void addmyButton()
        {
            myButton = new Button();
            myButton.Width = 40;
            myButton.Height = 30;
            myButton.Left = Width - myButton.Width - 5;
            myButton.Top = Height / 2 - myButton.Height / 2;
            myButton.Text = "...";
            myButton.Font = getFont();
            Controls.Add(myButton);
        }

        public void addMyEditBox()
        {
            if (ID.IndexOf("spawnButton") <= -1 && ID.IndexOf("btn_edit_") <= -1)
                return;
            myEditBox = new TextBox();
            myEditBox.Width = 60;
            myEditBox.Height = 30;
            myEditBox.Left = 5;
            myEditBox.Top = Height / 2 - myEditBox.Height / 2;
            myEditBox.Text = "06";
            myEditBox.TextAlign = HorizontalAlignment.Center;
            Controls.Add(myEditBox);
            fillEditBox();
        }

        public void addmyCheckBox()
        {
            hasCheckBox = EnableStrings != null && EnableStrings.Count > 0;
            if (!hasCheckBox)
                return;
            myCheckBox = new CheckBox();
            myCheckBox.Width = 14;
            myCheckBox.Height = 14;
            myCheckBox.Left = 5;
            myCheckBox.Top = Height / 2 - myCheckBox.Height / 2;
            Controls.Add(myCheckBox);
            myCheckBox.Enabled = false;
        }

        public static void saveHotkeys()
        {
            string str = "";
            if (buttonList.Count <= 0)
                return;
            for (int index = 0; index < buttonList.Count; ++index)
            {
                CheatButton button = buttonList[index];
                str = str + "|" + button.ID + "," + button.hotkey.ToString() + "," + button.controlKey.ToString();
            }
            saveBox.Text = str;
            saveBox.SaveFile("Keybinds.dat");
        }

        public static void load_hotkeys()
        {
            saveBox.LoadFile("Keybinds.dat");
            string text = saveBox.Text;

            if (text.Length <= 0)
                return;
            string str1 = text;

            char[] chArray1 = new char[1] { '|' };
            foreach (string str2 in str1.Split(chArray1))
            {
                char[] chArray2 = new char[1] { ',' };
                string[] strArray = str2.Split(chArray2);
                for (int index = 0; index < buttonList.Count; ++index)
                {
                    CheatButton button = buttonList[index];
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
            for (int index = 0; index < buttonList.Count; ++index)
            {
                if (buttonList[index] != null && buttonList[index].hotkeyMode)
                    flag = true;
            }
            return flag;
        }

        public static void Hookey()
        {
            if (hookInstalled)
                return;
            _hookID = SetHook(_proc);
            hookInstalled = true;
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process currentProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule mainModule = currentProcess.MainModule)
                    return SetWindowsHookEx(13, proc, GetModuleHandle(mainModule.ModuleName), 0U);
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)256)
            {
                uint keyVal = (uint)Marshal.ReadInt32(lParam);
                if (ModifierKeys != 0)
                    main.sLabel.Text = ModifierKeys.ToString() + " " + ((Keys)keyVal).ToString();
                else
                    main.sLabel.Text = ((Keys)keyVal).ToString();
                for (int index = 0; index < buttonList.Count; ++index)
                {
                    CheatButton button = buttonList[index];
                    if (button.hotkeyMode)
                        button.setHotkey(keyVal);
                    else if (!anyEditing() && button.hotkey > 0U && (int)button.hotkey == (int)keyVal && ModifierKeys == (Keys)button.controlKey)
                        button.hotkeyPressed(keyVal);
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(
          int idHook,
          LowLevelKeyboardProc lpfn,
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
          AllocationType flAllocationType,
          MemoryProtection flProtect);

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
            SuspendLayout();
            Cursor = Cursors.Hand;
            Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResumeLayout(false);
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
