﻿// Decompiled with JetBrains decompiler
// Type: GameConnector
// Assembly: YAMATAIPatch R4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5B3BBAAE-6003-4740-8AF6-CC1446CB3A90
// Assembly location: F:\Download\Compressed\yamatai4 (2)\YAMATAIPatch R4.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Win32;
using WindowsFormsApplication1;

public class GameConnector
{
    public const int PROCESS_ALL_ACCESS = 2035711;
    public static Process[] gameProcess;
    public static string gameName = "TombRaider";
    public static string gameName2 = "flub";
    public static bool gameFound = false;
    public static bool wrongVersion = false;
    public static IntPtr gameHandle;
    public static uint gameModuleStart;
    public static uint gameModuleOffset;
    public static bool ignoreTimer = false;

    [DllImport("kernel32.dll")]
    public static extern uint GetLastError();

    [DllImport("kernel32.dll")]
    public static extern void SetLastError(uint dwErrorCode);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr VirtualAllocEx(
      IntPtr hProcess,
      IntPtr lpAddress,
      uint dwSize,
      GameConnector.AllocationType flAllocationType,
      GameConnector.MemoryProtection flProtect);

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

    public static void log(string inString)
    {
        Console.WriteLine("Log: " + inString);
        main.addText(inString);
    }

    public static void status(string inString)
    {
        Console.WriteLine("Status:  " + inString);
        main.status(inString);
    }

    public static void getParams()
    {
        string[] commandLineArgs = Environment.GetCommandLineArgs();
        if (commandLineArgs.Length <= 1)
            return;
        File.Exists(commandLineArgs[1]);
    }

    public static void patchIntegrityCheck() => GameConnector.log("GameConnector::patchIntegrityCheck() - Nothing to patch.");

    public static void injectCodeCaves()
    {
        GameConnector.log("GameConnector::injectCodeCaves() - Attempting 2 injections. ");
        GameConnector.writeString((IntPtr)9712486, "EB 19 90 8B 87 B4 08 00 00 89 87 B8 08 00 00 C7 87 B4 08 00 00 00 00 00 00 EB D1 E8 00 00 00 00 8B 04 E4 83 C0 0E 89 30 EB 0A 90 90 90 90 90 90 90 90 90 90 58 90 90 C2 04 00");
    }

    public static void checkConnection()
    {
        if (!GameConnector.gameFound)
        {
            GameConnector.gameProcess = Process.GetProcessesByName(GameConnector.gameName);
            if (GameConnector.gameProcess.Length == 0)
                GameConnector.gameProcess = Process.GetProcessesByName(GameConnector.gameName2);
            if (GameConnector.gameProcess.Length > 0 && GameConnector.gameProcess[0] != null)
            {
                GameConnector.gameFound = true;
                GameConnector.gameHandle = GameConnector.OpenProcess(56U, 0, (uint)GameConnector.gameProcess[0].Id);
                GameConnector.gameModuleStart = (uint)GameConnector.gameProcess[0].MainModule.BaseAddress.ToInt32();
                GameConnector.gameModuleOffset = GameConnector.gameModuleStart - 4194304U;
                PrivyTokens.doShit();
                GameConnector.log("\n Game Found :: " + GameConnector.gameHandle.ToString());
                if (GameConnector.checkVersionFailed())
                {
                    GameConnector.gameFound = false;
                    GameConnector.wrongVersion = true;
                    main.status("Error! - Wrong game version.");
                    if (GameConnector.ignoreTimer)
                        return;
                    GameConnector.ignoreTimer = true;
                    int num = (int)MessageBox.Show("*****Wrong TombRaider.exe Version***** \nYou need version 1.1.748.0 (steam) \n\n Other versions may work but are not supported.\n\n Additional: \nDon't contact me to say \"it dusnt work\"\nunless you're absolutely fucking sure you\nhave the right version!\n\n  Sickle.");
                }
                else
                {
                    GameConnector.status("Game Found - Ready!");
                    GameConnector.injectCodeCaves();
                    GameConnector.patchIntegrityCheck();
                }
            }
            else
                main.status("Waiting for TombRaider.exe !");
        }
        else
        {
            if (Process.GetProcessesByName(GameConnector.gameName).Length != 0)
                return;
            GameConnector.disconnect();
        }
    }

    public static bool checkVersionFailed()
    {
        if (GameConnector.ReadByteAdjusted(12061760U) == (byte)86 && GameConnector.ReadByteAdjusted(10640542U) == (byte)80 && GameConnector.ReadByteAdjusted(8480848U) == (byte)15)
        {
            int num = (int)MessageBox.Show("You are using an older version of TombRaider - Please download YamataiPatch R1, or R2 if you can't update (this is V3).");
        }
        if (GameConnector.ReadByteAdjusted(12061758U) != (byte)15)
        {
            GameConnector.log("failed on 1");
            return true;
        }
        if (GameConnector.ReadByteAdjusted(10640546U) != (byte)235)
        {
            GameConnector.log("failed on 2");
            return true;
        }
        if (GameConnector.ReadByteAdjusted(8480848U) == (byte)15)
            return false;
        GameConnector.log("failed on 3");
        return true;
    }

    public static void disconnect() => GameConnector.gameFound = false;

    public static int writeString(IntPtr inAddress, string inString) => GameConnector.writeMem(inAddress, GameConnector.convertString(inString));

    public static byte[] convertString(string inString)
    {
        List<byte> byteList = new List<byte>();
        byte result = 0;
        for (int index = 0; index < inString.Length; index += 3)
        {
            string s = Regex.Replace((inString[index].ToString() + inString[index + 1].ToString()).Trim(), "\\s", "");
            if (byte.TryParse(s, NumberStyles.HexNumber, (IFormatProvider)null, out result))
            {
                byte num = byte.Parse(s, NumberStyles.AllowHexSpecifier);
                byteList.Add(num);
            }
            else
                GameConnector.log("Error: removing some garbage");
        }
        return byteList.ToArray();
    }

    public static int writeMem(IntPtr inAddress, byte[] inBytes)
    {
        int num1 = (int)GameConnector.gameModuleStart - 4194304 + inAddress.ToInt32();
        int lpflOldProtect = 0;
        Kernel.VirtualProtectEx(GameConnector.gameHandle, (IntPtr)num1, inBytes.Length, 64, ref lpflOldProtect);
        GameConnector.VirtualAllocEx(GameConnector.gameHandle, (IntPtr)num1, (uint)inBytes.Length, GameConnector.AllocationType.Commit, GameConnector.MemoryProtection.ExecuteReadWrite);
        int num2 = GameConnector.WriteProcessMemory(GameConnector.gameHandle, (IntPtr)num1, inBytes, (uint)inBytes.Length, (IntPtr)0);
        if (num2 == 1)
            GameConnector.log("Write Succeeded");
        else
            GameConnector.log("Write Failed");
        return num2;
    }

    public static string ReadString(uint pointer)
    {
        byte[] numArray = new byte[24];
        GameConnector.ReadProcessMemory(GameConnector.gameHandle, (IntPtr)(long)pointer, numArray, (UIntPtr)24U, 0U);
        return Encoding.UTF8.GetString(numArray);
    }

    public static byte ReadByteAdjusted(uint pointer) => GameConnector.ReadByte(pointer + GameConnector.gameModuleOffset);

    public static byte ReadByte(uint pointer)
    {
        byte[] lpBuffer = new byte[1];
        GameConnector.ReadProcessMemory(GameConnector.gameHandle, (IntPtr)(long)pointer, lpBuffer, (UIntPtr)1U, 0U);
        return lpBuffer[0];
    }

    public static int ReadOffset(uint pointer, uint offset)
    {
        byte[] lpBuffer = new byte[24];
        uint lpBaseAddress = (uint)GameConnector.ReadPointer(pointer) + offset;
        GameConnector.ReadProcessMemory(GameConnector.gameHandle, (IntPtr)(long)lpBaseAddress, lpBuffer, (UIntPtr)4U, 0U);
        return BitConverter.ToInt32(lpBuffer, 0);
    }

    public static int ReadPointerAdjusted(uint pointer) => GameConnector.ReadPointer(pointer + GameConnector.gameModuleOffset);

    public static int ReadPointer(uint pointer)
    {
        byte[] lpBuffer = new byte[24];
        GameConnector.ReadProcessMemory(GameConnector.gameHandle, (IntPtr)(long)pointer, lpBuffer, (UIntPtr)4U, 0U);
        return BitConverter.ToInt32(lpBuffer, 0);
    }

    public enum Protection : uint
    {
        PAGE_NOACCESS = 1,
        PAGE_READONLY = 2,
        PAGE_READWRITE = 4,
        PAGE_WRITECOPY = 8,
        PAGE_EXECUTE = 16, // 0x00000010
        PAGE_EXECUTE_READ = 32, // 0x00000020
        PAGE_EXECUTE_READWRITE = 64, // 0x00000040
        PAGE_EXECUTE_WRITECOPY = 128, // 0x00000080
        PAGE_GUARD = 256, // 0x00000100
        PAGE_NOCACHE = 512, // 0x00000200
        PAGE_WRITECOMBINE = 1024, // 0x00000400
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

    private class GDI32
    {
        public const int SRCCOPY = 13369376;

        [DllImport("gdi32.dll")]
        public static extern bool BitBlt(
          IntPtr hObject,
          int nXDest,
          int nYDest,
          int nWidth,
          int nHeight,
          IntPtr hObjectSource,
          int nXSrc,
          int nYSrc,
          int dwRop);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        [DllImport("gdi32.dll")]
        public static extern bool DeleteDC(IntPtr hDC);

        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
    }

    private class User32
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref GameConnector.User32.RECT rect);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string sClassName, string sAppName);

        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
    }
}
