// Decompiled with JetBrains decompiler
// Type: GameHooks
// Assembly: YAMATAIPatch R4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5B3BBAAE-6003-4740-8AF6-CC1446CB3A90
// Assembly location: F:\Download\Compressed\yamatai4 (2)\YAMATAIPatch R4.exe

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GameHooks
{
    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 256;
    private static GameHooks.LowLevelKeyboardProc _proc = new GameHooks.LowLevelKeyboardProc(GameHooks.HookCallback);
    private static IntPtr _hookID = IntPtr.Zero;
    public static bool hotkeysDisabled = false;

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(
      int idHook,
      GameHooks.LowLevelKeyboardProc lpfn,
      IntPtr hMod,
      uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

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
      GameHooks.AllocationType flAllocationType,
      GameHooks.MemoryProtection flProtect);

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

    [DllImport("kernel32.dll")]
    private static extern bool ReadProcessMemory(
      IntPtr hProcess,
      IntPtr lpBaseAddress,
      byte[] lpBuffer,
      UIntPtr nSize,
      uint lpNumberOfBytesWritten);

    public static void Hookey() => GameHooks._hookID = GameHooks.SetHook(GameHooks._proc);

    private static IntPtr SetHook(GameHooks.LowLevelKeyboardProc proc)
    {
        using (Process currentProcess = Process.GetCurrentProcess())
        {
            using (ProcessModule mainModule = currentProcess.MainModule)
                return GameHooks.SetWindowsHookEx(13, proc, GameHooks.GetModuleHandle(mainModule.ModuleName), 0U);
        }
    }

    private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && wParam == (IntPtr)256)
            Console.WriteLine((object)(Keys)Marshal.ReadInt32(lParam));
        return GameHooks.CallNextHookEx(GameHooks._hookID, nCode, wParam, lParam);
    }

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

    private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
}
