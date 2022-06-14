using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RothPally.Helper
{
    internal class Util
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);
        const uint WM_KEYDOWN = 0x100;
        const uint WM_KEYUP = 0x101;

        const int PROCESS_WM_READ = 0x0010;
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
            [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);

        public static byte[] ReadBytes(IntPtr handle, long address, uint bytesToRead)
        {
            IntPtr ptrBytesRead;
            byte[] buffer = new byte[bytesToRead];

            ReadProcessMemory(handle, new IntPtr(address), buffer, bytesToRead, out ptrBytesRead);

            return buffer;
        }

        public static int ReadInt32(IntPtr handle, long address)
        {
            return BitConverter.ToInt32(ReadBytes(handle, address, 4), 0);
        }

        public static void postKey(Process proc, Keys keybind)
        {
            PostMessage(proc.MainWindowHandle, WM_KEYDOWN, (int)keybind, 0);
            PostMessage(proc.MainWindowHandle, WM_KEYUP, (int)keybind, 0);
        }

        public static void sendKey(Process proc, Keys keybind)
        {
            SendMessage(proc.MainWindowHandle, WM_KEYDOWN, (int)keybind, 0);
            SendMessage(proc.MainWindowHandle, WM_KEYUP, (int)keybind, 0);
        }

    }
}
