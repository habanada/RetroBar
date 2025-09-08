using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace RetroBar
{

    public static class KeyboardHelper
    {
        private const byte VK_LWIN = 0x5B;
        private const byte VK_SHIFT = 0x10;
        private const int KEYEVENTF_KEYDOWN = 0x0000;
        private const int KEYEVENTF_KEYUP = 0x0002;

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public static void SendWinShift()
        {
            keybd_event(VK_LWIN, 0, KEYEVENTF_KEYDOWN, 0);
        //    keybd_event(VK_SHIFT, 0, KEYEVENTF_KEYDOWN, 0);

          //  keybd_event(VK_SHIFT, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(VK_LWIN, 0, KEYEVENTF_KEYUP, 0);
        }
    }

}
