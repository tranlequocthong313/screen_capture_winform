using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace ScreenCapture
{
    internal class GlobalHotkey
    {
        private int modifier;
        private int key;
        private IntPtr hWnd;
        private int id;

        internal GlobalHotkey(int modifier, Keys key, Form form)
        {
            this.modifier = modifier;
            this.key = (int)key;
            this.hWnd = form.Handle;
            this.id = form.GetHashCode();
        }

        public override int GetHashCode()
        {
            return id;
        }

        internal bool Register()
        {
            return NativeMethods.RegisterHotKey(hWnd, id, modifier, key);
        }

        internal bool Unregister()
        {
            return NativeMethods.UnregisterHotKey(hWnd, id);
        }
    }
}

namespace ScreenCapture
{
    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int modifier, int key);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    }

    internal static class Constants
    {
        public const int MOD_SHIFT = 0x0004;
        public const int MOD_WIN = 0x0008;
        public const int WM_HOTKEY_MSG_ID = 0x0312;
    }
}