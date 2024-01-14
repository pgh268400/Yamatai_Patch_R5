// Decompiled with JetBrains decompiler
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
using System.Security.Cryptography;
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
    public static bool user_select_is_patch = true; // 유저가 패치 함을 선택했는지 여부
    public static bool gameFound; // 게임 찾음 여부 (프로세스 디텍트 여부)
    public static bool wrongVersion; // 게임 버전이 일치 하지 않는 경우
    public static IntPtr gameHandle;
    public static uint gameModuleStart;
    public static uint gameModuleOffset;
    public static bool ignoreTimer;


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

    public static void patchIntegrityCheck() => log("GameConnector::patchIntegrityCheck() - Nothing to patch.");

    public static void injectCodeCaves()
    {
        log("GameConnector::injectCodeCaves() - Attempting 2 injections. ");
        writeString((IntPtr)9712486, "EB 19 90 8B 87 B4 08 00 00 89 87 B8 08 00 00 C7 87 B4 08 00 00 00 00 00 00 EB D1 E8 00 00 00 00 8B 04 E4 83 C0 0E 89 30 EB 0A 90 90 90 90 90 90 90 90 90 90 58 90 90 C2 04 00");
    }

    public static void backup_original_files(string game_exe_path)
    {
        //game_exe 경로에서 파일명만 제외
        string dir_name = Path.GetDirectoryName(game_exe_path);

        //dir_name과 steam_api.dll 파일명을 합쳐서 경로를 만듬
        string steam_api_dll_path = Path.Combine(dir_name, "steam_api.dll");

        //tombraider_backup 폴더를 생성
        string backup_dir = Path.Combine(dir_name, "tombraider_backup");
        Directory.CreateDirectory(backup_dir);

        //steam_api.dll 파일을 tombraider_backup 폴더에 복사
        File.Copy(steam_api_dll_path, Path.Combine(backup_dir, "steam_api.dll"), true);

        //tombraider.exe 파일을 tombraider_backup 폴더에 복사
        File.Copy(game_exe_path, Path.Combine(backup_dir, gameName + ".exe"), true);
    }

    public static void patch_game_to_fit(string game_exe_path)
    {
        // 실행 파일 경로 위치에서 source 폴더를 찾는다
        string source_dir = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "patch");

        // source 폴더에 있는 파일들을 가져온다
        string[] files = Directory.GetFiles(source_dir);

        // 파일들을 하나씩 가져와서 실행 파일 경로 위치에 복사한다

        //game_exe 경로에서 파일명만 제외
        string dir_name = Path.GetDirectoryName(game_exe_path);

        foreach (string file in files)
        {
            //파일명만 가져옴
            string file_name = Path.GetFileName(file);

            //dir_name과 파일명을 합쳐서 경로를 만듬
            string dest_file_path = Path.Combine(dir_name, file_name);

            //파일을 복사
            File.Copy(file, dest_file_path, true);
        }
    }

    public static void checkConnection()
    {
        if (!gameFound)
        {
            gameProcess = Process.GetProcessesByName(gameName);
            if (gameProcess.Length == 0)
                gameProcess = Process.GetProcessesByName(gameName2);
            if (gameProcess.Length > 0 && gameProcess[0] != null)
            {
                gameFound = true;
                gameHandle = OpenProcess(56U, 0, (uint)gameProcess[0].Id);
                gameModuleStart = (uint)gameProcess[0].MainModule.BaseAddress.ToInt32();
                gameModuleOffset = gameModuleStart - 4194304U;
                PrivyTokens.doShit();
                log("\n Game Found :: " + gameHandle);

                // 먼저 스팀 최신 버전을 사용중인지 확인한다.
                if (user_select_is_patch && check_steam_latest_version())
                {
                    // 스팀 최신 버전(1.01)을 사용중인 경우 1.1.748.0 으로 자동 패치할 것인지 묻는다.
                    log("Steam latest version of Tomb Raider detected, patch required.");
                    DialogResult user_input = MessageBox.Show("Steam latest version of Tomb Raider detected (v1.01.0.0), patch required.\n\nDo you want to patch the game to 1.1.748.0?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (user_input == DialogResult.Yes)
                    {
                        // 실행 파일 경로에 patch 폴더가 없거나 비어있는 경우
                        /*
                        if (!Directory.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                                "patch")) ||
                            Directory.GetFiles(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "patch"))
                                .Length == 0)
                        {
                            MessageBox.Show("Patch files not found. Please download the patch files and place them in the patch folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                        */

                        try
                        {
                            // 사용자가 패치를 원하는 경우 패치를 진행한다.
                            log("User selected to patch the game.");

                            // 툼 레이더 게임 실행 파일의 경로를 가져온다.
                            string game_exe_path = gameProcess[0].MainModule.FileName;


                            // 현재 실행중인 툼레이더 프로세스를 강제 종료한다.
                            gameProcess[0].Kill();

                            // 프로세스가 종료될 때까지 대기한다.
                            gameProcess[0].WaitForExit();

                            // 원래 툼레이더 파일과 실행에 필요한 steam_api.dll 파일을 백업한다.
                            backup_original_files(game_exe_path);

                            // 패치를 진행한다.
                            patch_game_to_fit(game_exe_path);
                        }
                        catch (Exception e)
                        {
                            // 메세지로 출력
                            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // 패치 실패 출력
                            MessageBox.Show("Patch failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //프로그램 종료
                            Application.Exit();
                        }

                        // 패치가 완료되면 프로그램을 재시작 한다 - 재시작 메세지도 출력
                        MessageBox.Show("Patch complete. Please restart the game.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    else
                    {
                        log("User selected to not patch the game.");
                        user_select_is_patch = false;
                    }
                }

                if (check_version_failed())
                {
                    gameFound = false;
                    wrongVersion = true;
                    main.status("Error! - Wrong game version.");
                    if (ignoreTimer)
                        return;
                    ignoreTimer = true;
                    MessageBox.Show("*****Wrong TombRaider.exe Version***** \nYou need version 1.1.748.0 (steam) \n\n Other versions may work but are not supported.\n\n Additional: \nDon't contact me to say \"it doesn't work\"\nunless you're absolutely fucking sure you\nhave the right version!\n\n  Sickle.");
                }
                else
                {
                    status("Game Found - Ready!");
                    injectCodeCaves();
                    patchIntegrityCheck();
                }
            }
            else
                main.status("Waiting for TombRaider.exe !");
        }
        else
        {
            if (Process.GetProcessesByName(gameName).Length != 0)
                return;
            disconnect();
        }
    }

    // 스팀 최신 버전 체크 함수 (아래 버전 체크 함수보다 먼저 체크)
    public static bool check_steam_latest_version()
    {
        // 실행중인 게임 프로세스의 경로 얻어오기
        // 특정 이름을 가진 모든 프로세스 찾기
        Process[] processes = Process.GetProcessesByName(gameName);
        if (processes.Length <= 0) return false;

        // 여러 개의 프로세스 중 첫 번째 프로세스를 대상으로 선택
        Process target_process = processes[0];

        // 프로세스의 실행 파일 경로 얻기
        string game_file_path = target_process.MainModule.FileName;

        // 결과 출력
        //log(game_file_path);

        if (game_file_path.Trim() != "")
        {
            // 게임 파일의 해쉬값 체크
            string hash = calculate_file_hash(game_file_path);
            //log("GameConnector::check_steam_latest_version() - hash: " + hash);
            if (hash == "F36B8DD2BD74D48C14BF910AD9BD4AC9F4024433523FFC7E46D5C85C3DD618F5")
            {
                // 스팀 최신 버전 1.01 을 사용중인 경우
                return true;
            }
        }

        // 위 조건에 부합하지 않으면 스팀 최신 버전이 아님
        return false;
    }

    // exe 바이너리 파일을 읽어서 해쉬값을 리턴하는 함수
    public static string calculate_file_hash(string exe_file_path)
    {
        using (var sha256 = SHA256.Create())
        {
            // 파일을 스트림 형태로 읽어낸다
            using (var stream = File.OpenRead(exe_file_path))
            {
                // 파일의 해시 계산
                byte[] hash_bytes = sha256.ComputeHash(stream);

                // 계산된 해시를 문자열로 변환
                string hash_value = BitConverter.ToString(hash_bytes).Replace("-", String.Empty);
                return hash_value;
            }
        }
    }

    // 버전 체크 함수 (실행중에 프로세스 RAM 읽기로 체크)
    public static bool check_version_failed()
    {
        if (ReadByteAdjusted(12061760U) == 86 && ReadByteAdjusted(10640542U) == 80 && ReadByteAdjusted(8480848U) == 15)
        {
            MessageBox.Show("You are using an older version of TombRaider - Please download YamataiPatch R1, or R2 if you can't update (this is V3).");
        }
        if (ReadByteAdjusted(12061758U) != 15)
        {
            log("failed on 1");
            return true;
        }
        if (ReadByteAdjusted(10640546U) != 235)
        {
            log("failed on 2");
            return true;
        }
        if (ReadByteAdjusted(8480848U) == 15)
            return false;
        log("failed on 3");
        return true;
    }

    public static void disconnect() => gameFound = false;

    public static int writeString(IntPtr inAddress, string inString) => writeMem(inAddress, convertString(inString));

    public static byte[] convertString(string inString)
    {
        List<byte> byteList = new List<byte>();
        byte result = 0;
        for (int index = 0; index < inString.Length; index += 3)
        {
            string s = Regex.Replace((inString[index] + inString[index + 1].ToString()).Trim(), "\\s", "");
            if (byte.TryParse(s, NumberStyles.HexNumber, null, out result))
            {
                byte num = byte.Parse(s, NumberStyles.AllowHexSpecifier);
                byteList.Add(num);
            }
            else
                log("Error: removing some garbage");
        }
        return byteList.ToArray();
    }

    public static int writeMem(IntPtr inAddress, byte[] inBytes)
    {
        int num1 = (int)gameModuleStart - 4194304 + inAddress.ToInt32();
        int lpflOldProtect = 0;
        Kernel.VirtualProtectEx(gameHandle, (IntPtr)num1, inBytes.Length, 64, ref lpflOldProtect);
        VirtualAllocEx(gameHandle, (IntPtr)num1, (uint)inBytes.Length, AllocationType.Commit, MemoryProtection.ExecuteReadWrite);
        int num2 = WriteProcessMemory(gameHandle, (IntPtr)num1, inBytes, (uint)inBytes.Length, (IntPtr)0);
        if (num2 == 1)
            log("Write Succeeded");
        else
            log("Write Failed");
        return num2;
    }

    public static string ReadString(uint pointer)
    {
        byte[] numArray = new byte[24];
        ReadProcessMemory(gameHandle, (IntPtr)pointer, numArray, (UIntPtr)24U, 0U);
        return Encoding.UTF8.GetString(numArray);
    }

    public static byte ReadByteAdjusted(uint pointer) => ReadByte(pointer + gameModuleOffset);

    public static byte ReadByte(uint pointer)
    {
        byte[] lpBuffer = new byte[1];
        ReadProcessMemory(gameHandle, (IntPtr)pointer, lpBuffer, (UIntPtr)1U, 0U);
        return lpBuffer[0];
    }

    public static int ReadOffset(uint pointer, uint offset)
    {
        byte[] lpBuffer = new byte[24];
        uint lpBaseAddress = (uint)ReadPointer(pointer) + offset;
        ReadProcessMemory(gameHandle, (IntPtr)lpBaseAddress, lpBuffer, (UIntPtr)4U, 0U);
        return BitConverter.ToInt32(lpBuffer, 0);
    }

    public static int ReadPointerAdjusted(uint pointer) => ReadPointer(pointer + gameModuleOffset);

    public static int ReadPointer(uint pointer)
    {
        byte[] lpBuffer = new byte[24];
        ReadProcessMemory(gameHandle, (IntPtr)pointer, lpBuffer, (UIntPtr)4U, 0U);
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
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);

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
