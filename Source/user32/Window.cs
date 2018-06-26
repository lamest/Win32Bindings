using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Win32Bindings.user32
{
    /// <summary>
    ///     Class for managing Windows window.
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    [CLSCompliant(false)]
    public class Window
    {
        private const string DLLName = "User32.dll";

        /// <summary>
        ///     Determines whether the specified window handle identifies an existing window.
        /// </summary>
        /// <param name="hWnd">A handle to the window to be tested.</param>
        /// <returns>
        ///     If the window handle identifies an existing window, the return value is true. If the window handle does not
        ///     identify an existing window, the return value is false.
        /// </returns>
        [DllImport(DLLName)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindow(IntPtr hWnd);
    }
}