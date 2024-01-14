// Decompiled with JetBrains decompiler
// Type: PrivyTokens
// Assembly: YAMATAIPatch R4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5B3BBAAE-6003-4740-8AF6-CC1446CB3A90
// Assembly location: F:\Download\Compressed\yamatai4 (2)\YAMATAIPatch R4.exe

using System;
using System.Runtime.InteropServices;

internal class PrivyTokens
{
    public const string SE_ASSIGNPRIMARYTOKEN_NAME = "SeAssignPrimaryTokenPrivilege";
    public const string SE_AUDIT_NAME = "SeAuditPrivilege";
    public const string SE_BACKUP_NAME = "SeBackupPrivilege";
    public const string SE_CHANGE_NOTIFY_NAME = "SeChangeNotifyPrivilege";
    public const string SE_CREATE_GLOBAL_NAME = "SeCreateGlobalPrivilege";
    public const string SE_CREATE_PAGEFILE_NAME = "SeCreatePagefilePrivilege";
    public const string SE_CREATE_PERMANENT_NAME = "SeCreatePermanentPrivilege";
    public const string SE_CREATE_SYMBOLIC_LINK_NAME = "SeCreateSymbolicLinkPrivilege";
    public const string SE_CREATE_TOKEN_NAME = "SeCreateTokenPrivilege";
    public const string SE_DEBUG_NAME = "SeDebugPrivilege";
    public const string SE_ENABLE_DELEGATION_NAME = "SeEnableDelegationPrivilege";
    public const string SE_IMPERSONATE_NAME = "SeImpersonatePrivilege";
    public const string SE_INC_BASE_PRIORITY_NAME = "SeIncreaseBasePriorityPrivilege";
    public const string SE_INCREASE_QUOTA_NAME = "SeIncreaseQuotaPrivilege";
    public const string SE_INC_WORKING_SET_NAME = "SeIncreaseWorkingSetPrivilege";
    public const string SE_LOAD_DRIVER_NAME = "SeLoadDriverPrivilege";
    public const string SE_LOCK_MEMORY_NAME = "SeLockMemoryPrivilege";
    public const string SE_MACHINE_ACCOUNT_NAME = "SeMachineAccountPrivilege";
    public const string SE_MANAGE_VOLUME_NAME = "SeManageVolumePrivilege";
    public const string SE_PROF_SINGLE_PROCESS_NAME = "SeProfileSingleProcessPrivilege";
    public const string SE_RELABEL_NAME = "SeRelabelPrivilege";
    public const string SE_REMOTE_SHUTDOWN_NAME = "SeRemoteShutdownPrivilege";
    public const string SE_RESTORE_NAME = "SeRestorePrivilege";
    public const string SE_SECURITY_NAME = "SeSecurityPrivilege";
    public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
    public const string SE_SYNC_AGENT_NAME = "SeSyncAgentPrivilege";
    public const string SE_SYSTEM_ENVIRONMENT_NAME = "SeSystemEnvironmentPrivilege";
    public const string SE_SYSTEM_PROFILE_NAME = "SeSystemProfilePrivilege";
    public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";
    public const string SE_TAKE_OWNERSHIP_NAME = "SeTakeOwnershipPrivilege";
    public const string SE_TCB_NAME = "SeTcbPrivilege";
    public const string SE_TIME_ZONE_NAME = "SeTimeZonePrivilege";
    public const string SE_TRUSTED_CREDMAN_ACCESS_NAME = "SeTrustedCredManAccessPrivilege";
    public const string SE_UNDOCK_NAME = "SeUndockPrivilege";
    public const string SE_UNSOLICITED_INPUT_NAME = "SeUnsolicitedInputPrivilege";
    public const uint SE_PRIVILEGE_ENABLED_BY_DEFAULT = 1;
    public const uint SE_PRIVILEGE_ENABLED = 2;
    public const uint SE_PRIVILEGE_REMOVED = 4;
    public const uint SE_PRIVILEGE_USED_FOR_ACCESS = 2147483648;
    private static uint STANDARD_RIGHTS_REQUIRED = 983040;
    private static uint STANDARD_RIGHTS_READ = 131072;
    private static uint TOKEN_ASSIGN_PRIMARY = 1;
    private static uint TOKEN_DUPLICATE = 2;
    private static uint TOKEN_IMPERSONATE = 4;
    private static uint TOKEN_QUERY = 8;
    private static uint TOKEN_QUERY_SOURCE = 16;
    private static uint TOKEN_ADJUST_PRIVILEGES = 32;
    private static uint TOKEN_ADJUST_GROUPS = 64;
    private static uint TOKEN_ADJUST_DEFAULT = 128;
    private static uint TOKEN_ADJUST_SESSIONID = 256;
    private static uint TOKEN_READ = PrivyTokens.STANDARD_RIGHTS_READ | PrivyTokens.TOKEN_QUERY;
    private static uint TOKEN_ALL_ACCESS = PrivyTokens.STANDARD_RIGHTS_REQUIRED | PrivyTokens.TOKEN_ASSIGN_PRIMARY | PrivyTokens.TOKEN_DUPLICATE | PrivyTokens.TOKEN_IMPERSONATE | PrivyTokens.TOKEN_QUERY | PrivyTokens.TOKEN_QUERY_SOURCE | PrivyTokens.TOKEN_ADJUST_PRIVILEGES | PrivyTokens.TOKEN_ADJUST_GROUPS | PrivyTokens.TOKEN_ADJUST_DEFAULT | PrivyTokens.TOKEN_ADJUST_SESSIONID;

    [DllImport("advapi32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool OpenProcessToken(
      IntPtr ProcessHandle,
      uint DesiredAccess,
      out IntPtr TokenHandle);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr GetCurrentProcess();

    [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool LookupPrivilegeValue(
      string lpSystemName,
      string lpName,
      out PrivyTokens.LUID lpLuid);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool CloseHandle(IntPtr hHandle);

    [DllImport("advapi32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AdjustTokenPrivileges(
      IntPtr TokenHandle,
      [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges,
      ref PrivyTokens.TOKEN_PRIVILEGES NewState,
      uint Zero,
      IntPtr Null1,
      IntPtr Null2);

    public static void doShit()
    {
        IntPtr TokenHandle;
        if (!PrivyTokens.OpenProcessToken(PrivyTokens.GetCurrentProcess(), PrivyTokens.TOKEN_ADJUST_PRIVILEGES | PrivyTokens.TOKEN_QUERY, out TokenHandle))
        {
            Console.WriteLine("OpenProcessToken() failed, error = {0} . SeDebugPrivilege is not available", (object)Marshal.GetLastWin32Error());
        }
        else
        {
            Console.WriteLine("OpenProcessToken() successfully");
            PrivyTokens.LUID lpLuid;
            if (!PrivyTokens.LookupPrivilegeValue((string)null, "SeDebugPrivilege", out lpLuid))
            {
                Console.WriteLine("LookupPrivilegeValue() failed, error = {0} .SeDebugPrivilege is not available", (object)Marshal.GetLastWin32Error());
                PrivyTokens.CloseHandle(TokenHandle);
            }
            else
            {
                Console.WriteLine("LookupPrivilegeValue() successfully");
                PrivyTokens.TOKEN_PRIVILEGES NewState;
                NewState.PrivilegeCount = 1U;
                NewState.Luid = lpLuid;
                NewState.Attributes = 2U;
                if (!PrivyTokens.AdjustTokenPrivileges(TokenHandle, false, ref NewState, 0U, IntPtr.Zero, IntPtr.Zero))
                    Console.WriteLine("LookupPrivilegeValue() failed, error = {0} .SeDebugPrivilege is not available", (object)Marshal.GetLastWin32Error());
                else
                    Console.WriteLine("SeDebugPrivilege is now available");
                PrivyTokens.CloseHandle(TokenHandle);
                Console.ReadLine();
            }
        }
    }

    public struct LUID
    {
        public uint LowPart;
        public int HighPart;
    }

    public struct TOKEN_PRIVILEGES
    {
        public uint PrivilegeCount;
        public PrivyTokens.LUID Luid;
        public uint Attributes;
    }

    public struct LUID_AND_ATTRIBUTES
    {
        public PrivyTokens.LUID Luid;
        public uint Attributes;
    }
}
